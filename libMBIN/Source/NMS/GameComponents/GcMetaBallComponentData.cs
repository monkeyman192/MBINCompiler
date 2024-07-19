namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61EC5574575639E1, NameHash = 0x717A0738)]
    public class GcMetaBallComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f MaxSize;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector3f MinSize;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString File;
        [NMS(Index = 2)]
        /* 0x30 */ public float Radius;
        [NMS(Index = 1)]
        /* 0x34 */ public NMSString0x20 Root;
    }
}
