namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E7AEF917584CD7, NameHash = 0xFFDCD21B79EE81DE)]
    public class GcScreenFilterData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A LocText;
        [NMS(Index = 2)]
        /* 0x20 */ public float FadeDistance;
        [NMS(Index = 4)]
        /* 0x24 */ public float HdrAreaAdjust;
        [NMS(Index = 1)]
        /* 0x28 */ public NMSString0x80 Filename;
        [NMS(Index = 3)]
        /* 0xA8 */ public bool SelectableInPhotoMode;
    }
}
