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

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(Values):
                    var data = new float[3];
                    ushort raw = reader.ReadUInt16();
                    data[0] = (float)(raw & 0x1F) / 31;
                    data[1] = (float)((raw >> 5) & 0x1F) / 31;
                    data[2] = (float)((raw >> 10) & 0x1F) / 31;
                    return data;
            }
            return null;
        }
    }
}
