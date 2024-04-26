namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D8D5706A09E0855, NameHash = 0xD47F03EDECF73128)]
    public class GcMaintenanceSaveKey : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public int Location;
    }
}
