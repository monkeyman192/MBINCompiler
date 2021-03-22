using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.SketchNodes;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x50, GUID = 0xE32C93208E1FC4AE, NameHash = 0x34A0F43E0ECB3765)]
    public class TkSketchNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 TypeName;
        public enum TriggerTypeEnum { Disabled, Interrupt, RunParallel, Blocked, QueueLatest, QueueAll }
        /* 0x20 */ public TriggerTypeEnum TriggerType;
        /* 0x24 */ public int SelectedVariant;
        /* 0x28 */ public int PositionX;
        /* 0x2C */ public int PositionY;
        /* 0x30 */ public List<TkSketchNodeConnections> Connections;
        /* 0x40 */ public NMSTemplate CustomData;

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(CustomData):
                    writer.Align(8, fieldName);
                    // write empty list header
                    long listPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    writer.Write((Int32)fieldData.GetType().GetCustomAttribute<NMSAttribute>()?.Size); // listCount
                    writer.Write((UInt32)0xAAAAAA01);

                    additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, fieldData));
                    addtDataIndex++;

                    return true;
                default:
                    return false;
            }
        }

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(CustomData):
                    // Read the list data
                    reader.Align(0x8);
                    long listPosition = reader.BaseStream.Position;
                    long listStartOffset = reader.ReadInt64();
                    int entrySize = reader.ReadInt32();
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1) throw new InvalidListException(listMagic, reader.BaseStream.Position);

                    // Create the template of the type we care about
                    NMSTemplate template = NMSTemplate.TemplateFromName($"Sn{TypeName}");

                    // Move the reader to the appropriate location
                    var templatePosition = listPosition + listStartOffset;
                    reader.BaseStream.Position = templatePosition;
                    // Read the fields and then deserialise them one by one.
                    var fields = template.GetType().GetFields().OrderBy(field_ => field_.MetadataToken);
                    foreach (var f in fields) {
                        NMSAttribute settings_ = f.GetCustomAttribute<NMSAttribute>();
                        if (f.FieldType.IsEnum) {
                            f.SetValue(template, Enum.ToObject(f.FieldType, DeserializeValue(reader, f.FieldType, settings_, templatePosition, f, template)));
                        }
                        else {
                            f.SetValue(template, DeserializeValue(reader, f.FieldType, settings_, templatePosition, f, template));
                        }
                    }
                    reader.BaseStream.Position = listPosition + 0x10;
                    template.FinishDeserialize();
                    return template;
            }
            return null;
        }
    }
}
