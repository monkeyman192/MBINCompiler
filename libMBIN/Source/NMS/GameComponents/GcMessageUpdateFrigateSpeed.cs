namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE3A7C989C10A3D6, NameHash = 0xE81087792E50B0E9)]
    public class GcMessageUpdateFrigateSpeed : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float StartSpeed;
        [NMS(Index = 1)]
        /* 0x4 */ public float TargetSpeed;
    }
}
