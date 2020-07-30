using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x50, GUID = 0xE32C93208E1FC4AE, NameHash = 0x34A0F43E0ECB3765)]
    public class TkSketchNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 TypeName;
        public enum TriggerTypeEnum { Disabled, Interrupt, RunParallel, Blocked, QueueLatest, QueueAll }
        /* 0x20 */
        public TriggerTypeEnum TriggerType;
        /* 0x24 */
        public int SelectedVariant;
        /* 0x28 */
        public int PositionX;
        /* 0x2C */
        public int PositionY;
        /* 0x30 */
        public List<TkSketchNodeConnections> Connections;
        /* 0x40 */
        public NMSTemplate CustomData;
        // This is some kind of template that looks to be handled in a weird way by the exe.
        // My best guess at how it works is that depending on the value of TypeName, this data will contain different parameters.
        // Currently I won't try and RE it properly, but in the future we will want to.

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(CustomData):
                    Logger.LogMessage($"value of TypeName: {TypeName}");
                    // Read the list data
                    reader.Align(0x08);
                    long listPosition = reader.BaseStream.Position;
                    //DebugLog($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    long listStartOffset = reader.ReadInt64();
                    int entrySize = reader.ReadInt32();
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1) throw new InvalidListException(listMagic, reader.BaseStream.Position);

                    long listEndPosition = reader.BaseStream.Position;
                    Logger.LogMessage($"The thing is 0x{listStartOffset:x} bytes later than now");
                    Logger.LogMessage($"The thing has size 0x{entrySize:x}");
                    NMSTemplate template = NMSTemplate.TemplateFromName($"Sn{TypeName}");
                    Logger.LogMessage(template.GetType().GetCustomAttribute<NMSAttribute>()?.Size ?? 0);
                    reader.BaseStream.Position = listPosition + listStartOffset;
                    return template;
            }

            return null;
        }
    }
}
