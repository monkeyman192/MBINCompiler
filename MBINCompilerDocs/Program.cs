using System;
using System.Reflection;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using libMBIN;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;


namespace MBINCompilerDocs
{
    class Program
    {
        internal static readonly Dictionary<string, string> dtypeMapping = new Dictionary<string, string>
        {
            { "Single", "Float" },
        };

        // When running locally this needs to be one less directory up.
        static string basePath = Path.Combine("..", "..", "docs", "classes");

        //Create a mapping between the full names of tk and gc and the short-hands
        internal static readonly Dictionary<string, string> NMS_dir_mapping = new Dictionary<string, string>
                {
                    { "Toolkit", "tk" },
                    { "GameComponents", "gc" },
                    { "Globals", "globals" },
                    { "NMS", "nms" },
                };

        static void WaitForKeypress()
        {
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static internal void GenerateDirs()
        {
            foreach (var key in NMS_dir_mapping.Values) {
                Directory.CreateDirectory(Path.Combine(basePath, key.ToString()));
            }
        }

        static string GetNMSType(Type classType)
        {
            if (classType == typeof(NMSTemplate)) {
                // We hard-code this since it's namespace won't map to anything.
                // TODO: Maybe have 'libmbin' map to nms? Might be risky though...
                return "nms";
            }
            var splitname = classType.Namespace.Split('.');
            string last = splitname[splitname.Length - 1];
            if (NMS_dir_mapping.ContainsKey(last)) {
                return NMS_dir_mapping[last];
            } else {
                return null;
            }
        }

        static string ConvertDatatype(Type dtype)
        {
            string dtypeName = dtype.Name;
            if (dtypeMapping.ContainsKey(dtypeName)) {
                return dtypeMapping[dtypeName];
            } else {
                return dtypeName;
            }
        }

        static void export_md(List<Type> classes)
        {
            foreach (var t in classes) {
                // Create a stringBuilder object to use for the whole md document
                StringBuilder md = new StringBuilder();

                string name = t.Name;
                string NMSType = GetNMSType(t);
                int? size = t.GetCustomAttribute<NMSAttribute>()?.Size;
                ulong? guid = t.GetCustomAttribute<NMSAttribute>()?.GUID;

                // Write the class name and GUID
                md.AppendLine($"## [All classes](../../) > [{NMSType}](../) > {name}");
                if (t.Namespace != "libMBIN.NMS") {
                    md.AppendLine($"**Size**: 0x{size:X}, **GUID**: 0x{guid:X}\n");
                }
                md.AppendLine();

                // Let's get any descriptions if we have any...
                string class_desc = t.GetCustomAttribute<NMSDescription>()?.Description;
                if (class_desc != null) {
                    md.AppendLine(class_desc);
                    md.AppendLine();
                }

                // Write the table header
                md.AppendLine("| Name | Data type | Description |");
                md.AppendLine("| -----| --------- | ----------- |");

                // Get fields in order of declaration
                var fields = t.GetFields().OrderBy(field => field.MetadataToken);
                foreach (var field in fields) {
                    var field_attrs = field.GetCustomAttribute<NMSAttribute>();

                    // For each field in the class, write a row in the table
                    if (!(field.GetCustomAttribute<NMSAttribute>()?.Ignore ?? false)) {
                        var fieldType = field.FieldType;
                        // Write the field name first
                        md.Append($"| {field.Name} |");

                        // If the base type is based on NMSTemplate, then we want to create a hyperlink to the page.
                        string className = $"{ConvertDatatype(fieldType)}";
                        if (fieldType.BaseType == typeof(NMSTemplate) || fieldType == typeof(NMSTemplate)) {
                            var fieldNMSType = GetNMSType(fieldType);
                            if (fieldNMSType != null) {
                                className = $"[{fieldType.Name}](../../../classes/{fieldNMSType}/{fieldType.Name})";
                            }
                        }

                        // For enums, get the values it can have:
                        if (fieldType.IsEnum) {
                            md.Append("<div class='expandable'>Enum</div><ol class='enumValues' hidden>");
                            foreach (var enumValue in Enum.GetValues(fieldType)) {
                                var enumIndex = Convert.ChangeType(enumValue, Enum.GetUnderlyingType(fieldType));
                                md.Append($"<li val='0x{enumIndex:X}'>{enumValue.ToString()}</li>");
                            }
                            md.Append("</ol>");
                        }
                        // For a string, get its size:
                        else if (fieldType.Equals(typeof(System.String))) {
                            if (name == "VariableSizeString") {
                                md.Append($"String (0x??)");
                            } else {
                                int? strSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                                md.Append($"String (0x{strSize:X})");
                            }
                        }
                        // For an array, get it's size and potential enum values:
                        else if (fieldType.IsArray) {
                            int? arrSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            var arrayEnumType = field.GetCustomAttribute<NMSAttribute>()?.EnumType;
                            className = className.Substring(0, className.Length - 2);
                            // For enums, get the values it can have:
                            if (arrayEnumType != null && arrayEnumType.IsEnum) {
                                md.Append($"<div class='expandable'>{className}[0x{arrSize:X}]</div><ul class='enumValues' hidden>");
                                foreach (var enumValue in Enum.GetValues(arrayEnumType)) {
                                    md.Append($"<li>{enumValue.ToString()}</li>");
                                }
                                md.Append("</ul>");
                            } else {
                                md.Append($"{className}[0x{arrSize:X}]");
                            }
                        }
                        // For a list, get the list type:
                        else if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>)) {
                            var refType = field.FieldType.GetGenericArguments()[0];
                            string dtypeName = ConvertDatatype(refType);
                            string listClassName = $"{dtypeName}";
                            if (refType.BaseType == typeof(NMSTemplate) || refType == typeof(NMSTemplate)) {
                                var listNMSType = GetNMSType(refType);
                                if (listNMSType != null) {
                                    listClassName = $"[{dtypeName}](../../../classes/{listNMSType}/{dtypeName})";
                                }
                            }
                            md.Append($"List<{listClassName}\\>");
                        }
                        // This is the case of a NMSTemplate or standard type.
                        // TODO: handle the NMSTemplate case here and above...
                        else {
                            md.Append($"{className}");
                        }
                        // See if the field has a description
                        string desc = field.GetCustomAttribute<NMSDescription>()?.Description;
                        if (desc != null) {
                            md.AppendLine($" | {desc} |");
                        } else {
                            md.AppendLine(" | |");
                        }
                    }
                }

                // Now, write everything to a file...
                File.WriteAllText(Path.Combine(basePath, NMSType, $"{name}.md"), md.ToString());
            }
        }

        static void export_xml(List<Type> classes, string outName)
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement tkNode = xmlDoc.CreateElement(outName);
            foreach (var t in classes) {
                string name = t.Name;
                int? size = t.GetCustomAttribute<NMSAttribute>()?.Size;

                // Write the name and size.
                XmlElement classNode = xmlDoc.CreateElement(name);

                XmlAttribute attribute = xmlDoc.CreateAttribute("size");
                attribute.Value = $"0x{size:X}";
                classNode.Attributes.Append(attribute);

                // Get fields in order of declaration
                var fields = t.GetFields().OrderBy(field => field.MetadataToken);
                foreach (var field in fields) {
                    if (!field.Name.Contains("Padding")) {
                        var fieldType = field.FieldType;
                        XmlElement fieldNode = xmlDoc.CreateElement(field.Name);
                        XmlAttribute typeAttr = xmlDoc.CreateAttribute("type");
                        // For enums, get the values it can have:
                        if (fieldType.IsEnum) {
                            foreach (var enumValue in Enum.GetValues(fieldType)) {
                                XmlElement valNode = xmlDoc.CreateElement(enumValue.ToString());
                                fieldNode.AppendChild(valNode);
                            }
                        }
                        // For a string, get its size:
                        if (fieldType.Equals(typeof(System.String))) {
                            int? strSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            XmlAttribute sizeAttr = xmlDoc.CreateAttribute("size");
                            sizeAttr.Value = $"0x{strSize:X}";
                            fieldNode.Attributes.Append(sizeAttr);
                        }
                        // For an array, get it's size and potential enum values:
                        if (fieldType.IsArray) {
                            int? strSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            XmlAttribute sizeAttr = xmlDoc.CreateAttribute("size");
                            sizeAttr.Value = $"0x{strSize:X}";
                            fieldNode.Attributes.Append(sizeAttr);
                            var arrayEnumType = field.GetCustomAttribute<NMSAttribute>()?.EnumType;
                            // For enums, get the values it can have:
                            if (arrayEnumType != null && arrayEnumType.IsEnum) {
                                foreach (var enumValue in Enum.GetValues(arrayEnumType)) {
                                    XmlElement valNode = xmlDoc.CreateElement(enumValue.ToString());
                                    fieldNode.AppendChild(valNode);
                                }
                            }
                        }
                        // For a list, get the list type:
                        if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>)) {
                            XmlAttribute listTypeAttr = xmlDoc.CreateAttribute("listType");
                            listTypeAttr.Value = field.ReflectedType.Name;
                            fieldNode.Attributes.Append(listTypeAttr);
                        }

                        typeAttr.Value = fieldType.Name;
                        fieldNode.Attributes.Append(typeAttr);
                        classNode.AppendChild(fieldNode);
                    }
                }
                tkNode.AppendChild(classNode);
                xmlDoc.AppendChild(tkNode);

                xmlDoc.Save($"{outName}_classes.xml");
                Console.WriteLine($"template: {name}, size: 0x{size:X}");
            }
        }

        static void update_class_list(List<Type> classes, StringBuilder md, bool includeDir = false) {
            foreach (var t in classes) {
                Console.WriteLine(t);
                var classNMSType = GetNMSType(t);
                foreach (CustomAttributeNamedArgument cata in t.CustomAttributes.First().NamedArguments)
                {
                    Console.WriteLine(cata.MemberName);
                    Console.WriteLine(cata.TypedValue.Value);
                }
                int? size = t.GetCustomAttribute<NMSAttribute>()?.Size;
                //Console.WriteLine(size);
                ulong? guid = t.GetCustomAttribute<NMSAttribute>()?.GUID;
                if (classNMSType != null) {
                    if (includeDir == true) {
                        if (t.Namespace != "libMBIN.NMS") {
                            md.AppendLine($"| [{t.Name}]({classNMSType}/{t.Name}) | 0x{guid:X} | 0x{size:X} |");
                        }
                        else {
                            md.AppendLine($"| [{t.Name}]({classNMSType}/{t.Name}) | 0x{size:X} |");
                        }
                    } else {
                        if (t.Namespace != "libMBIN.NMS") {
                            md.AppendLine($"| [{t.Name}]({t.Name}) | 0x{guid:X} | 0x{size:X} |");
                        }
                        else {
                            md.AppendLine($"| [{t.Name}]({t.Name}) | 0x{size:X} |");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            if (args.Length == 1) {
                // in this case we have passed an argument to the exe. This will indicate we are running on a CI
                if (args[0] == "CI") {
                    basePath = Path.Combine("docs", "classes");
                }
            }
            // Load the assembly (will be located in the same directory as this binary)
            var asm = Assembly.Load("libMBIN");
            // Load all the classes
            var tk_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS.Toolkit" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            var gc_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS.GameComponents" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            var globals_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS.Globals" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            var base_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            // Create the directory if needed
            GenerateDirs();

            // Write all the classes to a single file
            StringBuilder md = new StringBuilder();
            md.AppendLine("# List of all Classes");
            md.AppendLine();
            md.AppendLine("### [Base classes](nms)");
            md.AppendLine();
            md.AppendLine(@"These are some base classes which are used all through out. 
                          They are not defined as such in the exe, and are named/defined as required.");
            md.AppendLine();
            md.AppendLine("| Name | Size |");
            md.AppendLine("| ---- | ---- |");
            md.AppendLine("| [NMSTemplate](nms/NMSTemplate) | 0x50 |");
            update_class_list(base_classes, md, true);
            md.AppendLine();
            md.AppendLine("### [Globals](globals)");
            md.AppendLine();
            md.AppendLine("Globals are classes which are a fixed size and vary many aspects of the game (hence the name!).");
            md.AppendLine();
            md.AppendLine("| Name | GUID | Size |");
            md.AppendLine("| ---- | ---- | ---- |");
            update_class_list(globals_classes, md, true);
            md.AppendLine();
            md.AppendLine("### [GameComponents (Gc)](gc)");
            md.AppendLine();
            md.AppendLine("| Name | GUID | Size |");
            md.AppendLine("| ---- | ---- | ---- |");
            update_class_list(gc_classes, md, true);
            md.AppendLine();
            md.AppendLine("### [Toolkits (Tk)](tk)");
            md.AppendLine();
            md.AppendLine("| Name | GUID | Size |");
            md.AppendLine("| ---- | ---- | ---- |");
            update_class_list(tk_classes, md, true);
            File.WriteAllText(Path.Combine(basePath, "index.md"), md.ToString());

            // Also write each index of classes to its own file
            StringBuilder md_base = new StringBuilder();
            md_base.AppendLine("# [All classes](../) > Base classes");
            md_base.AppendLine();
            md_base.AppendLine("| Name | Size |");
            md_base.AppendLine("| ---- | ---- |");
            md_base.AppendLine("| [NMSTemplate](NMSTemplate) | 0x50 |");
            update_class_list(base_classes, md_base);
            File.WriteAllText(Path.Combine(basePath, "nms", "index.md"), md_base.ToString());

            StringBuilder md_gc = new StringBuilder();
            md_gc.AppendLine("# [All classes](../) > GameComponent (Gc)");
            md_gc.AppendLine();
            md_gc.AppendLine("| Name | GUID | Size |");
            md_gc.AppendLine("| ---- | ---- | ---- |");
            update_class_list(gc_classes, md_gc);
            File.WriteAllText(Path.Combine(basePath, "gc", "index.md"), md_gc.ToString());

            StringBuilder md_tk = new StringBuilder();
            md_tk.AppendLine("# [All classes](../) > Tookit (Tk)");
            md_tk.AppendLine();
            md_tk.AppendLine("| Name | GUID | Size |");
            md_tk.AppendLine("| ---- | ---- | ---- |");
            update_class_list(tk_classes, md_tk);
            File.WriteAllText(Path.Combine(basePath, "tk", "index.md"), md_tk.ToString());

            StringBuilder md_globals = new StringBuilder();
            md_globals.AppendLine("# [All classes](../) > Globals");
            md_globals.AppendLine();
            md_globals.AppendLine("| Name | GUID | Size |");
            md_globals.AppendLine("| ---- | ---- | ---- |");
            update_class_list(globals_classes, md_globals);
            File.WriteAllText(Path.Combine(basePath, "globals", "index.md"), md_globals.ToString());
            export_md(base_classes);
            export_md(tk_classes);
            export_md(gc_classes);
            export_md(globals_classes);

            // Write the NMSTemplate info
            StringBuilder md_NMSTemplate = new StringBuilder();
            md_NMSTemplate.AppendLine("## [All classes](../../) > [nms](../) > NMSTemplate");
            md_NMSTemplate.AppendLine();
            md_NMSTemplate.AppendLine("This is the base class that all others are subclassed from.");
            md_NMSTemplate.Append("This class also has a number of methods available to it (and be extension, all subclasses) ");
            md_NMSTemplate.AppendLine("which can be found [here](../../../libmbin/usage/#nmstemplate)");
            md_NMSTemplate.AppendLine();
            md_NMSTemplate.Append("If this is a field type in some other class (either on its own or in a list for example), ");
            md_NMSTemplate.AppendLine("this can be thought of as a generic type.");
            md_NMSTemplate.AppendLine();
            md_NMSTemplate.AppendLine("| Name | Data type | Description |");
            md_NMSTemplate.AppendLine("| -----| --------- | ----------- |");
            md_NMSTemplate.AppendLine("| Offset | Int64 | The relative offset from this location to the stored class |");
            md_NMSTemplate.AppendLine("| ClassName | String (0x40) | The (compiled) name of the class (eg. cTkPhysicsComponentData) |");
            md_NMSTemplate.AppendLine("| NameHash | UInt64 | A Hash of the name of the class |");
            md_NMSTemplate.AppendLine();
            File.WriteAllText(Path.Combine(basePath, "nms", "NMSTemplate.md"), md_NMSTemplate.ToString());

            //WaitForKeypress();
        }
    }
}
