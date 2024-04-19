namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C277BE778F63AF4, NameHash = 0xFFDCD21B79EE81DE)]
    public class GcScreenFilterData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LocText;
        /* 0x20 */ public float FadeDistance;
        /* 0x24 */ public float HdrAreaAdjust;
        /* 0x28 */ public NMSString0x80 Filename;
        /* 0xA8 */ public bool SelectableInPhotoMode;
    }
}
