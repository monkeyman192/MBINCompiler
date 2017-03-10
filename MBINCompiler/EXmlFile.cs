using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using MBINCompiler.Models;

namespace MBINCompiler
{
    public static class EXmlFile
    {
        private static readonly XmlSerializer Serializer = new XmlSerializer(typeof(EXmlData));
        private static readonly XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });

        public static NMSTemplate ReadTemplate(string filePath)
        {
            using (var input = File.OpenRead(filePath))
                return ReadTemplateFromStream(input);
        }

        public static NMSTemplate ReadTemplateFromString(string xml)
        {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            using (var reader = new StringReader(xml))
            using (var xmlReader = XmlReader.Create(reader))
            {
                var template = ReadTemplateFromXmlReader(xmlReader);
                Thread.CurrentThread.CurrentCulture = origCulture;
                return template;
            }
        }

        public static NMSTemplate ReadTemplateFromStream(Stream input)
        {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            using (var reader = XmlReader.Create(input))
            {
                var template = ReadTemplateFromXmlReader(reader);
                Thread.CurrentThread.CurrentCulture = origCulture;
                return template;
            }
        }

        private static NMSTemplate ReadTemplateFromXmlReader(XmlReader reader)
        {
            EXmlData root = (EXmlData)Serializer.Deserialize(reader);
            NMSTemplate rootTemplate = NMSTemplate.DeserializeEXml(root);
            return rootTemplate;
        }

        public static EXmlData ReadExmlDataFromString(string xml)
        {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            using (var reader = new StringReader(xml))
            using (var xmlReader = XmlReader.Create(reader))
            {
                var data = (EXmlData)Serializer.Deserialize(xmlReader);
                Thread.CurrentThread.CurrentCulture = origCulture;
                return data;
            }
        }

        public static string WriteTemplate(NMSTemplate template)
        {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var xmlSettings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };
            using (var stringWriter = new EncodedStringWriter(Encoding.UTF8))
            using (var xmlTextWriter = XmlWriter.Create(stringWriter, xmlSettings))
            {
                string ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                xmlTextWriter.WriteComment(String.Format("File created using MBINCompiler version ({0})", ver.Substring(0, ver.Length - 2)));
                var data = template.SerializeEXml(false);
                Serializer.Serialize(xmlTextWriter, data, Namespaces);
                xmlTextWriter.Flush();

                var xmlData = stringWriter.GetStringBuilder().ToString();
                Thread.CurrentThread.CurrentCulture = origCulture;
                return xmlData;
            }
        }

        private sealed class EncodedStringWriter : StringWriter
        {
            public EncodedStringWriter(Encoding encoding)
            {
                Encoding = encoding;
            }

            public override Encoding Encoding { get; }
        }
    }
}