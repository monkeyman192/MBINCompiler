namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60C68E3ADC829D6A, NameHash = 0x6706D122)]
    public class GcScreenFilterData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A LocText;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString Filename;
        [NMS(Index = 2)]
        /* 0x30 */ public float FadeDistance;
        [NMS(Index = 4)]
        /* 0x34 */ public float HdrAreaAdjust;
        [NMS(Index = 3)]
        /* 0x38 */ public bool SelectableInPhotoMode;
    }
}
