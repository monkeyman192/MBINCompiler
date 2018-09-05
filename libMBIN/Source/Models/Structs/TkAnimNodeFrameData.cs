using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class TkAnimNodeFrameData : NMSTemplate
    {
        public List<short> Rotations;       //dummy
        public List<Vector4f> Translations;
        public List<Vector4f> Scales;

        /*
        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(Rotations):
                    // sort out reading of list
                    long listPosition = reader.BaseStream.Position;
                    //DebugLog($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32();
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    var indices = new List<short>();
                    int j = 0;
                    List<Vector4f> data = new List<Vector4f>();
                    UInt16 c_x = 0x3FFF;
                    UInt16 c_y = 0x3FFF;
                    UInt16 c_z = 0x3FFF;
                    float norm = 1.0f / 0x3FFF;
                    float scale = 1.0f / (float)Math.Sqrt(2.0f);
                    for (int i = 0; i < numEntries; i++)
                    {
                        // assign the variables
                        if (j == 0)
                            c_x = reader.ReadUInt16();
                        else if (j == 1)
                            c_y = reader.ReadUInt16();
                        else if (j == 2)
                            c_z = reader.ReadUInt16();

                        // if j == 2 construct the new 4-vector and populate it
                        if (j == 2)
                        {
                            Vector4f q = new Vector4f();
                            q.x = ((float)(c_x - 0x3FFF)) * norm * scale;
                            q.y = ((float)(c_y - 0x3FFF)) * norm * scale;
                            q.z = ((float)(c_z - 0x3FFF)) * norm * scale;

                            q.x = q.x % scale;
                            q.y = q.y % scale;
                            q.z = q.z % scale;

                            //I assume that W is positive by default
                            q.t = (float)Math.Sqrt(Math.Max(1.0f - q.x * q.x - q.y * q.y - q.z * q.z, 0.0));
                            data.Add(q);
                            j = 0;
                        }
                        else
                            j += 1;
                    }

                    return data;
            }
            return null;
        }*/
    }
}

/*
def read_as_comp_q_4(val):
    v = 0
    for i in range(6):
        v |= val[i] << 8*(5-i)
        #v |= val[i] << 8*i
    
    print("start value", v, hex(v))
    v1 = (v >> 32) & 0xFFFF
    v2 = (v >> 16) & 0xFFFF
    v3 = (v >> 1) & 0x7FFF
    v4 = v & 0x1

    #scale = 1.0 / 1.4142
    scale = 1.0
    print("values", v1, v2, v3, v4)
    print("conv_values", ((float(v1) - 0x7FFF) / 0x7FFF), 
                         ((float(v2) - 0x7FFF) / 0x7FFF), 
                         ((float(v3) - 0x3FFF) / 0x3FFF))
*/