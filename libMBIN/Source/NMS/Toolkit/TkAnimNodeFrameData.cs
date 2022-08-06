using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x122A23E7D278667B, NameHash = 0x270204EDCEE4DB62)]
    public class TkAnimNodeFrameData : NMSTemplate
    {
        public List<Quaternion> Rotations;
        public List<Vector3f> Translations;
        public List<Vector3f> Scales;

        
        public override object CustomDeserialize( BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo ) {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
            {
                case nameof(Rotations):
                    // sort out reading of list
                    long listPosition = reader.BaseStream.Position;

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32()/3;
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1) throw new InvalidListException( listMagic, reader.BaseStream.Position );

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    // output data
                    List<Quaternion> data = new List<Quaternion>();
                    // worker values
                    UInt16 c_x, c_y, c_z;
                    UInt16 i_x, i_y;
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

                        // determine most significant bit (0 or 1)
                        i_x = (UInt16)(c_x >> 0xF);
                        i_y = (UInt16)(c_y >> 0xF);
                        //i_z = (UInt16)(c_z >> 0xF);

                        /* dropcomponent indicates which component of the quaternion has been dropped
                        3 -> x
                        2 -> y
                        1 -> z
                        0 -> w */
                        ushort dropcomponent = (ushort)(i_x << 1 | i_y << 0);

                        //Mask Values (strip most significant bit)
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

                        switch (dropcomponent)
                        {
                            case 3:     // qx was dropped
                                qo = new Quaternion(q.w, q.x, q.y, q.z);
                                break;
                            case 2:     // qy was dropped
                                qo = new Quaternion(q.x, q.w, q.y, q.z);
                                break;
                            case 1:     // qz was dropped
                                qo = new Quaternion(q.x, q.y, q.w, q.z);
                                break;
                            case 0:     // qw was dropped
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

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            if (field == null || fieldInfo == null)
                return false;

            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(Rotations):

                    IList<Quaternion> data = (IList<Quaternion>)fieldData;

                    List<UInt16> outputData = new List<UInt16>();

                    // write empty list header
                    long listPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    writer.Write((Int32)0); // listCount
                    writer.Write((UInt32)0x00000001);

                    if ( data == null ) return true;

                    foreach (Quaternion q in data)
                    {
                        List<UInt16> convertedQ = new List<UInt16>
                        {ConvertQuat(q.x),
                         ConvertQuat(q.y),
                         ConvertQuat(q.z),
                         ConvertQuat(q.w)};

                        int dropcomponent = (int)DetermineDropComponent(convertedQ);

                        // remove the element we wish to discard
                        convertedQ.RemoveAt(dropcomponent);

                        dropcomponent = 3 - dropcomponent;      // flip the number to correspond to the correct component

                        int i_x = dropcomponent >> 1;
                        int i_y = dropcomponent & 1;

                        convertedQ[0] = (UInt16)((i_x << 0xF) + (int)convertedQ[0]);
                        convertedQ[1] = (UInt16)((i_y << 0xF) + (int)convertedQ[1]);

                        // extend the ouput data
                        outputData.AddRange(convertedQ);

                    }

                    additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, outputData));
                    addtDataIndex++;
                    return true;
            }

            return false;
        }

        private UInt16 DetermineDropComponent(List<UInt16> arr)
        {
            UInt16 max_loc = 0;        // x by default
            HashSet<UInt16> doubled_elements = new HashSet<UInt16>();
            HashSet<UInt16> condensed_arr = new HashSet<UInt16>();
            // add all the elements in arr to the set version
            foreach (UInt16 i in arr)
            {
                if (condensed_arr.Contains(i))
                {
                    doubled_elements.Add(i);
                }
                condensed_arr.Add(i);
            }
            if (condensed_arr.Count == 4)
            {
                // in this case we simply want the max
                UInt16 max_val = arr.Max();
                max_loc = (UInt16)arr.IndexOf(max_val);
            }
            else
            {
                // we have a doubled element
                if (!doubled_elements.Contains(0x3FFF))
                {
                    max_loc = 0;        // remove x
                }
                else
                {
                    UInt16 max_val = arr.Max();
                    max_loc = (UInt16)arr.IndexOf(max_val);
                }
            }

            return max_loc;
        }

        private UInt16 ConvertQuat(float qi)
        {
            return (UInt16)(0x3FFF * (Math.Sqrt(2) * qi + 1));
        }
    }
}