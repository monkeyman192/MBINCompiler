using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkGeometryData : NMSTemplate
    {
        public int VertexCount;
        public int IndexCount;
        public int Indices16Bit;

        public List<TkJointBindingData> JointBindings;
        public List<TkJointExtentData> JointExtents;

        public List<int> JointMirrorPairs;
        public List<TkJointMirrorAxis> JointMirrorAxes;

        public List<int> SkinMatrixLayout;
        public List<int> MeshVertRStart;
        public List<int> MeshVertREnd;
        public List<int> MeshBaseSkinMat;
        public List<Vector4f> MeshAABBMin;
        public List<Vector4f> MeshAABBMax;

        public TkVertexLayout VertexLayout;
        public TkVertexLayout SmallVertexLayout;

        public List<int> IndexBuffer;
        public List<float> VertexStream;
        public List<float> SmallVertexStream;

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            if (field == null || fieldInfo == null)
                return false;

            var fieldName = fieldInfo.Name;
            switch(fieldName)
            {
                case nameof(IndexBuffer):
                    writer.Align(8, fieldName);

                    // write empty list header
                    long listPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    writer.Write((Int32)0); // listCount
                    writer.Write((UInt32)0xAAAAAA01);

                    IList data = (IList)fieldData;

                    if(Indices16Bit != 1) // if 32bit indices, we can just pass it directly
                        additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, data)); 
                    else
                    {
                        // otherwise we have to create 32bit indices from the 16bit ones
                        var list32Bit = new List<uint>();
                        for(int i = 0; i < data.Count; i += 2)
                        {
                            uint val32Bit = (uint)((int)data[i+1] << 16 | (int)data[i]);
                            list32Bit.Add(val32Bit);
                        }
                        additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, list32Bit));
                    }
                    addtDataIndex++;

                    return true;

                case nameof(VertexStream):
                case nameof(SmallVertexStream):
                    writer.Align(8, fieldName);

                    // write empty list header
                    long listPos2 = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    writer.Write((Int32)0); // listCount
                    writer.Write((UInt32)0xAAAAAA01);

                    IList vertexData = (IList)fieldData;

                    // list size field for VertexStream/SmallVertexSteam is the number of bytes, so we'll have to use a List<byte> in the additionalData
                    byte[] streamData = null;
                    using (var ms = new MemoryStream())
                    using (var writer2 = new BinaryWriter(ms))
                    {
                        if(vertexData != null)
                            foreach (var vertex in vertexData)
                            {
                                var floatVertex = (float)vertex;
                                var halfVertex = (Half)floatVertex;
                                writer2.Write(halfVertex.value);
                            }
                        streamData = ms.ToArray();
                    }

                    var listBytes = new List<byte>(streamData);
                    additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos2, listBytes));
                    addtDataIndex++;

                    return true;
            }

            return false;
        }

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;
            switch (fieldName)
            {
                case nameof(IndexBuffer):
                    reader.Align(8);
                    long listPosition = reader.BaseStream.Position;
                    Debug.WriteLine($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32() * ((Indices16Bit == 1) ? 2 : 1); // Adjust size
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    var indices = new List<int>();
                    for (int i = 0; i < numEntries; i++)
                    {
                        if (Indices16Bit == 1)
                        {
                            indices.Add((int)reader.ReadUInt16());
                        }
                        else
                        {
                            indices.Add((int)reader.ReadUInt32());
                        }
                    }

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x8);

                    return indices;

                case nameof(VertexStream):
                case nameof(SmallVertexStream):
                    reader.Align(8);
                    listPosition = reader.BaseStream.Position;
                    Debug.WriteLine($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    listStartOffset = reader.ReadInt64();
                    numEntries = reader.ReadInt32();
                    listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

                    listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    List<float> vertices = new List<float>();
                    while (reader.BaseStream.Position < (listPosition + listStartOffset + numEntries))
                    {
                        ushort vertex = reader.ReadUInt16();
                        vertices.Add((float)Half.ToHalf(vertex));
                    }

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x8);

                    return vertices;
            }

            return null;
        }
    }
}