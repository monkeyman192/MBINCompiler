using System;
using System.Text;
using System.Text.Json;
using System.Text.Encodings.Web;
using SpookilySharp;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using libMBIN;

namespace SaveFileMapping
{
    public class MappingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (name == "Item1") { return "Key"; }
            if (name == "Item2") { return "Value"; }
            return "Unknown";  // If we hit this bad things have happened...
        }
    }

    class Program
    {
        /// <summary>
        /// Full credit to this code goes to AndASM for determining this
        /// Their repository with the original code can be found here: https://github.com/AndASM/AndASM-NMS
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string HashName(string name)
        {
            var output = new byte[3];
            var message = Encoding.UTF8.GetBytes(name);
            var hash = message.SpookyHash128(0, message.Length, 8268756125562466087, 8268756125562466087);

            // Character set starts at '0' UTF-8, 68 characters, with an offset of +6 after 'Z'
            // Character set: "0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxy"
            output[0] = (byte)(hash.UHash1 % 68 + '0');
            output[1] = (byte)((hash.UHash1 >> 21) % 68 + '0');
            output[2] = (byte)((hash.UHash1 >> 42) % 68 + '0');

            for (var i = 0; i < output.Length; i++)
                if (output[i] > 'Z')
                    output[i] += 6;

            return Encoding.UTF8.GetString(output);
        }

        static void UpdateHashes(Type fieldType, HashSet<Tuple<string, string>> data)
        {
            var fields = fieldType.GetFields().OrderBy(field => field.MetadataToken);
            foreach (var field in fields)
            {
                string name = field.Name;
                if (!name.StartsWith("Padding") && !name.EndsWith("Padding"))
                {
                    if (field.FieldType.BaseType.Name == "NMSTemplate")
                    {
                        UpdateHashes(field.FieldType, data);
                    }
                    else if (field.FieldType.Name == "List`1")
                    {
                        var ListType = field.FieldType.GetGenericArguments()[0];
                        if (ListType.BaseType == typeof(NMSTemplate) && !typeof(libMBIN.NMS.INMSString).IsAssignableFrom(ListType))
                        {
                            UpdateHashes(ListType, data);
                        }
                    }
                    if (field.FieldType.IsArray)
                    {
                        var arrayType = field.FieldType.GetElementType();
                        if (arrayType.BaseType.Name == "NMSTemplate")
                        {
                            UpdateHashes(arrayType, data);
                        }
                    }
                    string hashed = HashName(name);
                    var new_data = new Tuple<string, string>(hashed, name);
                    data.Add(new_data);
                }
            }
        }


        static void Main(string[] args)
        {
            var save_mapping = new HashSet<Tuple<string, string>>();
            UpdateHashes(typeof(libMBIN.NMS.GameComponents.GcPlayerStateData), save_mapping);
            // Add some other values we need:
            // Added Keys:
            save_mapping.Add(new Tuple<string, string>(HashName("Version"), "Version"));
            save_mapping.Add(new Tuple<string, string>(HashName("Platform"), "Platform"));
            save_mapping.Add(new Tuple<string, string>(HashName("ActiveContext"), "ActiveContext"));
            save_mapping.Add(new Tuple<string, string>(HashName("GameMode"), "GameMode"));
            save_mapping.Add(new Tuple<string, string>(HashName("ReserveStore"), "ReserveStore"));
            save_mapping.Add(new Tuple<string, string>(HashName("ReserveManaged"), "ReserveManaged"));
            // Open Objects:
            save_mapping.Add(new Tuple<string, string>(HashName("CommonStateData"), "CommonStateData"));
            // CommonStateData is of type GcPlayerCommonStateData
            UpdateHashes(typeof(libMBIN.NMS.GameComponents.GcPlayerCommonStateData), save_mapping);
            save_mapping.Add(new Tuple<string, string>(HashName("BaseContext"), "BaseContext"));
            save_mapping.Add(new Tuple<string, string>(HashName("ExpeditionContext"), "ExpeditionContext"));
            save_mapping.Add(new Tuple<string, string>(HashName("PlayerStateData"), "PlayerStateData"));
            save_mapping.Add(new Tuple<string, string>(HashName("SpawnStateData"), "SpawnStateData"));
            save_mapping.Add(new Tuple<string, string>(HashName("GameKnowledgeData"), "GameKnowledgeData"));
            save_mapping.Add(new Tuple<string, string>(HashName("DiscoveryManagerData"), "DiscoveryManagerData"));
            save_mapping.Add(new Tuple<string, string>(HashName("DiscoveryData-v1"), "DiscoveryData-v1"));
            // Open Arrays:
            save_mapping.Add(new Tuple<string, string>(HashName("MultiTool"), "MultiTool"));
            save_mapping.Add(new Tuple<string, string>(HashName("Waypoints"), "Waypoints"));
            // Waypoints is a list of GcGalaxyWaypoint's:
            UpdateHashes(typeof(libMBIN.NMS.GameComponents.GcGalaxyWaypoint), save_mapping);
            // Session::SavePersistent
            save_mapping.Add(new Tuple<string, string>(HashName("Store"), "Store"));
            save_mapping.Add(new Tuple<string, string>(HashName("Record"), "Record"));
            save_mapping.Add(new Tuple<string, string>(HashName("TSrec"), "TSrec"));
            save_mapping.Add(new Tuple<string, string>(HashName("Available"), "Available"));
            save_mapping.Add(new Tuple<string, string>(HashName("Enqueued"), "Enqueued"));
            // Not sure if these are still used, but kept for any kind of backward compatibility.
            save_mapping.Add(new Tuple<string, string>(HashName("OWS"), "OWS"));
            save_mapping.Add(new Tuple<string, string>(HashName("LID"), "LID"));
            save_mapping.Add(new Tuple<string, string>(HashName("UID"), "UID"));
            save_mapping.Add(new Tuple<string, string>(HashName("DM"), "DM"));
            save_mapping.Add(new Tuple<string, string>(HashName("CN"), "CN"));
            save_mapping.Add(new Tuple<string, string>(HashName("FL"), "FL"));
            save_mapping.Add(new Tuple<string, string>(HashName("RID"), "RID"));
            save_mapping.Add(new Tuple<string, string>(HashName("PTK"), "PTK"));
            save_mapping.Add(new Tuple<string, string>(HashName("H"), "H"));
            save_mapping.Add(new Tuple<string, string>(HashName("R"), "R"));
            save_mapping.Add(new Tuple<string, string>(HashName("C"), "C"));
            save_mapping.Add(new Tuple<string, string>(HashName("U"), "U"));
            save_mapping.Add(new Tuple<string, string>(HashName("F"), "F"));
            save_mapping.Add(new Tuple<string, string>(HashName("DD"), "DD"));
            save_mapping.Add(new Tuple<string, string>(HashName("UA"), "UA"));
            save_mapping.Add(new Tuple<string, string>(HashName("DT"), "DT"));
            save_mapping.Add(new Tuple<string, string>(HashName("VP"), "VP"));
            save_mapping.Add(new Tuple<string, string>(HashName("TS"), "TS"));
            save_mapping.Add(new Tuple<string, string>(HashName("USN"), "USN"));

            // Also add the GcUserSettingsData class
            var account_mapping = new HashSet<Tuple<string, string>>();
            account_mapping.Add(new Tuple<string, string>(HashName("UserSettingsData"), "UserSettingsData"));
            UpdateHashes(typeof(libMBIN.NMS.GameComponents.GcUserSettingsData), account_mapping);

            var main_data = new Dictionary<string, object>();
            main_data["libMBIN_version"] = libMBIN.Version.AssemblyVersion.ToString();
            main_data["Mapping"] = save_mapping.ToList().Concat(account_mapping.ToList());
            // main_data["Mapping_save"] = save_mapping; // alternatively split mapping in 2
            // main_data["Mapping_account"] = account_mapping;

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = new MappingPolicy(),
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                //WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(main_data, options);

            using (StreamWriter sw = new StreamWriter("mapping.json"))
            {
                sw.Write(jsonString);
            }
        }
    }
}
