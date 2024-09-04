namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6BCC7662105914B, NameHash = 0x1123713C)]
    public class GcSkiffSaveData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector4f Direction;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector4f Position;
        [NMS(Index = 0)]
        /* 0x20 */ public ulong Location;
    }
}
