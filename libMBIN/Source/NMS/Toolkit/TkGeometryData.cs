using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

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
    }
}
