namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x409E58991CD749D8, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Axis;
        /* 0x10 */ public float Speed;
        /* 0x14 */ public int SyncGroup;
        /* 0x18 */ public bool AlwaysUpdate;
    }
}
