using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class TkAnimNodeFrameData : NMSTemplate
    {
        public List<Quaternion> Rotations;
        public List<Vector4f> Translations;
        public List<Vector4f> Scales;

        
        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(Rotations):
                    // sort out reading of list
                    long listPosition = reader.BaseStream.Position;

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32()/3;
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1) throw new InvalidListException( listMagic );

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    // output data
                    List<Quaternion> data = new List<Quaternion>();
                    // worker values
                    UInt16 c_x, c_y, c_z;
                    UInt16 i_x, i_y, i_z;
                    // a few normalisation/scaling values
                    float norm = 1.0f / 0x3FFF;
                    float scale = 1.0f / (float)Math.Sqrt(2.0f);
                    // now, iterate over the input data.
                    // We will read in the data in chunks of 6 bytes
                    for (int i = 0; i < numEntries; i++)
                    {
                        // assign the variables
                        c_x = reader.ReadUInt16();
                        c_y = reader.ReadUInt16();
                        c_z = reader.ReadUInt16();

                        // make these things
                        i_x = (UInt16)(c_x >> 15);
                        i_y = (UInt16)(c_y >> 15);
                        i_z = (UInt16)(c_z >> 15);

                        ushort axisflag = (ushort)(i_x << 0 | i_y << 1 | i_z << 2);

                        //Mask Values
                        c_x = (UInt16)(c_x & 0x7FFF);
                        c_y = (UInt16)(c_y & 0x7FFF);
                        c_z = (UInt16)(c_z & 0x7FFF);

                        Quaternion q = new Quaternion(
                            ((float)(c_x - 0x3FFF)) * norm * scale,
                            ((float)(c_y - 0x3FFF)) * norm * scale,
                            ((float)(c_z - 0x3FFF)) * norm * scale,
                            0.0f);

                        //I assume that W is positive by default
                        q.w = (float)Math.Sqrt(Math.Max(1.0f - q.x * q.x - q.y * q.y - q.z * q.z, 0.0));
                        // output Quaternion
                        Quaternion qo;

                        switch (axisflag)
                        {
                            case 3:
                                qo = new Quaternion(q.w, q.x, q.y, q.z);
                                break;
                            case 2:
                                qo = new Quaternion(q.x, q.y, q.w, q.z);
                                break;
                            case 1:
                                qo = new Quaternion(q.x, q.w, q.y, q.z);
                                break;
                            case 0:
                                qo = new Quaternion(q.x, q.y, q.z, q.w);
                                break;
                            default:
                                qo = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);        // shouldn't ever get here
                                break;
                        }
                        data.Add(qo);
                    }

                    // the padding bytes are just ignored...

                    reader.BaseStream.Position = listEndPosition;
                    return data;
            }
            return null;
        }
    }
}