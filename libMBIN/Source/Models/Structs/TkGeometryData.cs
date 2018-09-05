using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x140)]
    public class TkGeometryData : NMSTemplate
    {
        /* 0x000 */ public int VertexCount;
        /* 0x004 */ public int IndexCount;
        /* 0x008 */ public int Indices16Bit;
        /* 0x00C */ public int CollisionIndexCount;

        /* 0x010 */ public List<TkJointBindingData> JointBindings;
        /* 0x020 */ public List<TkJointExtentData> JointExtents;

        /* 0x030 */ public List<int> JointMirrorPairs;
        /* 0x040 */ public List<TkJointMirrorAxis> JointMirrorAxes;

        /* 0x050 */ public List<int> SkinMatrixLayout;
        /* 0x060 */ public List<int> MeshVertRStart;
        /* 0x070 */ public List<int> MeshVertREnd;
        /* 0x080 */ public List<int> BoundHullVertSt;
        /* 0x090 */ public List<int> BoundHullVertEd;
        /* 0x0A0 */ public List<int> MeshBaseSkinMat;
        /* 0x0B0 */ public List<Vector4f> MeshAABBMin;
        /* 0x0C0 */ public List<Vector4f> MeshAABBMax;

        /* 0x0D0 */ public List<Vector4f> BoundHullVerts;

        /* 0x0E0 */ public TkVertexLayout VertexLayout;
        /* 0x100 */ public TkVertexLayout SmallVertexLayout;

        /* 0x120 */ public List<int> IndexBuffer;
        /* 0x130 */ public List<TkMeshMetaData> StreamMetaDataArray;
        /* 0x130 */
        public List<float> VertexStream;
        /* 0x140 */
        public List<float> SmallVertexStream;


        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            if (field == null || fieldInfo == null)
                return false;

            Dictionary<int, int> TypeMap = new Dictionary<int, int> { { 5131, 8 }, { 36255, 4 }, { 5121, 4 } };

            var fieldName = fieldInfo.Name;
            switch(fieldName)
            {
                case nameof(IndexBuffer):
                    writer.Align(8, 0);

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
                        int effective_count = (data.Count / 2) * 2;

                        for (int i = 0; i < effective_count; i += 2)
                        {
                            uint val32Bit = (uint)((int)data[i + 1] << 16 | (int) data[i]);
                            list32Bit.Add(val32Bit);
                        }

                        //Handle odd cases
                        if (data.Count % 2 == 1)
                        {
                            //uint val32Bit = (uint)((int)data[data.Count - 1] << 16);
                            uint val32Bit = (uint)((int)data[data.Count - 1]);
                            list32Bit.Add(val32Bit);
                        }

                        additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, list32Bit));
                    }
                    addtDataIndex++;

                    return true;

                case nameof(VertexStream):
                case nameof(SmallVertexStream):
                    writer.Align(8, 0);

                    List<int> LayoutTypes = new List<int>();
                    TkVertexLayout layout;

                    if (fieldName == nameof(VertexStream))
                        layout = VertexLayout;
                    else
                        layout = SmallVertexLayout;

                    foreach (TkVertexElement ve in layout.VertexElements)
                    {
                        int type = ve.Type;
                        LayoutTypes.Add(type);
                    }
                    int stride = 4 * LayoutTypes.Count;

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
                        if (vertexData != null)
                        {
                            for (int v = 0; v < VertexCount; v++)
                            {
                                for (int i = 0; i < LayoutTypes.Count; i++)
                                {
                                    if (LayoutTypes[i] == 5131)
                                    {
                                        // half-float
                                        for (int j = 0; j < 4; j++)
                                        {
                                            var floatVertex = (float)vertexData[v * stride + 4 * i + j];
                                            var halfVertex = (Half)floatVertex;
                                            writer2.Write(halfVertex.value);
                                        }
                                    }
                                    else if (LayoutTypes[i] == 5121)
                                    {
                                        // Unsigned bytes
                                        for (int j = 0; j < 4; j++)
                                        {
                                            byte ubyteVertex = (byte)vertexData[v * stride + 4 * i + j];
                                            writer2.Write(ubyteVertex);
                                        }
                                    }
                                    else if (LayoutTypes[i] == 36255)
                                    {
                                        // INT_2_10_10_10_REV
                                        float[] vertexes = new float[4] {(float)vertexData[v * stride + 4 * i],
                                                                         (float)vertexData[v * stride + 4 * i + 1],
                                                                         (float)vertexData[v * stride + 4 * i + 2],
                                                                         (float)vertexData[v * stride + 4 * i + 3] };
                                        int val = INT_2_10_10_10_REV.FromVerts(vertexes);
                                        writer2.Write((UInt32)val);
                                    }
                                }
                            }
                        }
                        streamData = ms.ToArray();

                    }
                        /*
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
                        }*/

                    var listBytes = new List<byte>(streamData);
                    additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos2, listBytes));
                    addtDataIndex++;

                    return true;
            }

            return false;
        }

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            var fieldName = fieldInfo.Name;

            Dictionary<int, int> TypeMap = new Dictionary<int, int> { { 5131, 8 }, { 36255, 4 }, { 5121, 4 } };

            switch (fieldName)
            {
                case nameof(IndexBuffer):
                    reader.Align(8, 0);
                    long listPosition = reader.BaseStream.Position;
                    //Debug.WriteLine($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

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
                    reader.Align(0x8, 0);

                    return indices;

                case nameof(VertexStream):
                case nameof(SmallVertexStream):

                    List<int> LayoutTypes = GetTypeLayouts(fieldName, reader);
                    int StreamBlockSize = 0;
                    foreach (int vert_type in LayoutTypes)
                    {
                        StreamBlockSize += TypeMap[vert_type];
                    }
                    reader.Align(8, 0);
                    listPosition = reader.BaseStream.Position;
                    //Debug.WriteLine($"TkGeometryData.CustomDeserialize({fieldName}) start 0x{listPosition:X}");

                    listStartOffset = reader.ReadInt64();
                    numEntries = reader.ReadInt32()/StreamBlockSize;   // the number of blocks of data
                    listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1)
                        throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

                    listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    List<float> vertices = new List<float>();
                    int curr_block = 0;
                    while (curr_block < numEntries)
                    {
                        foreach (int ltype in LayoutTypes)
                        {
                            if (ltype == 5131)
                            // Half floats
                            {
                                // read in the half-float data
                                for (int i = 0; i < 4; i++)
                                {
                                    ushort vertex = reader.ReadUInt16();
                                    vertices.Add((float)Half.ToHalf(vertex));
                                }
                            }
                            else if (ltype == 5121)
                            // Unsigned bytes
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    byte num = reader.ReadByte();
                                    vertices.Add((float)(int)num);
                                }
                            }
                            else if (ltype == 36255)
                            {
                                int vert_data = reader.ReadInt32();
                                vertices.AddRange(INT_2_10_10_10_REV.FromBytes(vert_data));
                            }
                        }
                        curr_block += 1;
                    }
                    /*
                    while (reader.BaseStream.Position < (listPosition + listStartOffset + numEntries))
                    {
                        ushort vertex = reader.ReadUInt16();
                        vertices.Add((float)Half.ToHalf(vertex));
                    }*/

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x8, 0);

                    return vertices;
            }

            return null;
        }

        private List<int> GetTypeLayouts(string fieldName, BinaryReader reader)
        {
            List<int> LayoutTypes = new List<int>();

            long initialOffset = 0;

            if (fieldName == nameof(SmallVertexStream))
            {
                initialOffset = 0x100 + 0x60;
            }
            else if (fieldName == nameof(VertexStream))
            {
                initialOffset = 0xE0 + 0x60;
            }

            // I think we need to read the data manually :/
            long StartPosition = reader.BaseStream.Position;
            reader.BaseStream.Seek(initialOffset + 0x10, SeekOrigin.Begin);
            // read the offset and then the number of elements
            long VertexElementsStartOffset = reader.ReadInt64();
            int numVertexElements = reader.ReadInt32();
            // jump to the right location, but subtract the fact we have just read 0xC bytes
            reader.BaseStream.Seek(VertexElementsStartOffset - 0xC, SeekOrigin.Current);
            // iterate over the TkVertexElements
            for (int i = 0; i < numVertexElements; i++)
            {
                reader.BaseStream.Seek(0x8, SeekOrigin.Current);
                int vertex_type = (int)reader.ReadInt32();
                LayoutTypes.Add(vertex_type);
                reader.BaseStream.Seek(0x14, SeekOrigin.Current);
            }

            // reset the position
            reader.BaseStream.Position = StartPosition;
            // pretend we did nothing...
            return LayoutTypes;
        }
    }
}