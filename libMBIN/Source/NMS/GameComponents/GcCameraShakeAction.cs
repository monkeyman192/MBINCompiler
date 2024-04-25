namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E28DC14407484A8, NameHash = 0x8C20E93C658FEFB1)]
    public class GcCameraShakeAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Shake;
        [NMS(Index = 2)]
        /* 0x10 */ public float FalloffMax;
        [NMS(Index = 1)]
        /* 0x14 */ public float FalloffMin;
    }
}
