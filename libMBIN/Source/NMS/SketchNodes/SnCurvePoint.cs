using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x2, Alignment = 0x2)]
    public class SnCurvePoint : NMSTemplate
    {
        // WIP
        [NMS(Size = 0x3)]
        public float[] Values;

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(Values):
                    float[] data = (float[])fieldData;
                    ushort temp = 0;
                    temp += (ushort)(data[0] * 31);
                    temp += (ushort)((int)(data[1] * 31) << 5);
                    temp += (ushort)((int)(data[2] * 63) << 10);
                    writer.Write(temp);
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
                case nameof(Values):
                    var data = new float[3];
                    ushort raw = reader.ReadUInt16();
                    data[0] = (float)(raw & 0b11111) / 31;
                    data[1] = (float)((raw >> 5) & 0b11111) / 31;
                    data[2] = (float)((raw >> 10) & 0b111111) / 63;
                    return data;
            }
            return null;
        }
    }
}
