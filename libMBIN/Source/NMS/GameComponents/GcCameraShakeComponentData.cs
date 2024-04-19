namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35996503195FB978, NameHash = 0x77B3408A8150441E)]
    public class GcCameraShakeComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ShakeID;
        /* 0x10 */ public float FalloffDistanceMax;
        /* 0x14 */ public float FalloffDistanceMin;
    }
}
