using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x32F6AE7B03222A1F, NameHash = 0x819C3220)]
    public class TkGeometryData : NMSTemplate
    {
        [NMS(Index = 20)]
        /* 0x000 */ public TkVertexLayout SmallVertexLayout;
        [NMS(Index = 19)]
        /* 0x020 */ public TkVertexLayout VertexLayout;
        [NMS(Index = 12)]
        /* 0x040 */ public List<int> BoundHullVertEd;
        [NMS(Index = 16)]
        /* 0x050 */ public List<Vector4f> BoundHullVerts;
        [NMS(Index = 11)]
        /* 0x060 */ public List<int> BoundHullVertSt;
        [NMS(Index = 21)]
        /* 0x070 */ public List<int> IndexBuffer;
        [NMS(Index = 4)]
        /* 0x080 */ public List<TkJointBindingData> JointBindings;
        [NMS(Index = 5)]
        /* 0x090 */ public List<TkJointExtentData> JointExtents;
        [NMS(Index = 7)]
        /* 0x0A0 */ public List<TkJointMirrorAxis> JointMirrorAxes;
        [NMS(Index = 6)]
        /* 0x0B0 */ public List<int> JointMirrorPairs;
        [NMS(Index = 15)]
        /* 0x0C0 */ public List<Vector4f> MeshAABBMax;
        [NMS(Index = 14)]
        /* 0x0D0 */ public List<Vector4f> MeshAABBMin;
        [NMS(Index = 13)]
        /* 0x0E0 */ public List<int> MeshBaseSkinMat;
        [NMS(Index = 10)]
        /* 0x0F0 */ public List<int> MeshVertREnd;
        [NMS(Index = 9)]
        /* 0x100 */ public List<int> MeshVertRStart;
        [NMS(Index = 18)]
        /* 0x110 */ public List<VariableSizeString> ProcGenNodeNames;
        [NMS(Index = 17)]
        /* 0x120 */ public List<int> ProcGenParentId;
        [NMS(Index = 8)]
        /* 0x130 */ public List<int> SkinMatrixLayout;
        [NMS(Index = 22)]
        /* 0x140 */ public List<TkMeshMetaData> StreamMetaDataArray;
        [NMS(Index = 3)]
        /* 0x150 */ public int CollisionIndexCount;
        [NMS(Index = 1)]
        /* 0x154 */ public int IndexCount;
        [NMS(Index = 2)]
        /* 0x158 */ public int Indices16Bit;
        [NMS(Index = 0)]
        /* 0x15C */ public int VertexCount;
        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex) {
            if (field == null || fieldInfo == null) return false;

            Dictionary<int, int> TypeMap = new Dictionary<int, int> { { 5131, 8 }, { 36255, 4 }, { 5121, 4 } };

            var fieldName = fieldInfo.Name;
            switch (fieldName) {
                case nameof(IndexBuffer):
                    writer.Align(8, fieldName, 0xFE);

                    // write empty list header
                    long listPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    writer.Write((Int32)0); // listCount
                    writer.Write((UInt32)0x00000001);

                    IList data = (IList)fieldData;

                    if (Indices16Bit != 1) { // if 32bit indices, we can just pass it directly
                        additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, data));
                    }
                    else {
                        // otherwise we have to create 32bit indices from the 16bit ones
                        var list32Bit = new List<uint>();
                        int effective_count = (data.Count / 2) * 2;

                        for (int i = 0; i < effective_count; i += 2) {
                            uint val32Bit = (uint)((int)data[i + 1] << 16 | (int)data[i]);
                            list32Bit.Add(val32Bit);
                        }

                        //Handle odd cases
                        if (data.Count % 2 == 1) {
                            //uint val32Bit = (uint)((int)data[data.Count - 1] << 16);
                            uint val32Bit = (uint)((int)data[data.Count - 1]);
                            list32Bit.Add(val32Bit);
                        }

                        additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, list32Bit));
                    }
                    addtDataIndex++;
                    return true;
            }

            return false;
        }

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo) {
            var fieldName = fieldInfo.Name;

            Dictionary<int, int> TypeMap = new Dictionary<int, int> { { 5131, 8 }, { 36255, 4 }, { 5121, 4 } };

            switch (fieldName) {
                case nameof(IndexBuffer):
                    reader.Align(0x08);
                    long listPosition = reader.BaseStream.Position;

                    // Need to read the Indices16Bit value before anything else otherwise it will be wrong.
                    int Indices16BitOffset = OffsetOf("Indices16Bit");
                    int currRelOffset = OffsetOf("IndexBuffer");
                    // Jump to the location of the Indices16Bit field.
                    reader.BaseStream.Position = reader.BaseStream.Position + Indices16BitOffset - currRelOffset;
                    int _Indices16Bit = reader.ReadInt32();
                    reader.BaseStream.Position = listPosition;

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32() * ((_Indices16Bit == 1) ? 2 : 1); // Adjust size
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1) throw new InvalidListException(listMagic, reader.BaseStream.Position);

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    var indices = new List<int>();
                    for (int i = 0; i < numEntries; i++) {
                        if (_Indices16Bit == 1) {
                            indices.Add((int)reader.ReadUInt16());
                        }
                        else {
                            indices.Add((int)reader.ReadUInt32());
                        }
                    }

                    reader.BaseStream.Position = listEndPosition;
                    reader.Align(0x08);

                    return indices;
            }

            return null;
        }
    }
}
