namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE014A96716C169DE, NameHash = 0x6706D122)]
    public class GcScreenFilterData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A LocText;
        [NMS(Index = 2)]
        /* 0x20 */ public GcFilename FilenameHdr;
        [NMS(Index = 1)]
        /* 0x30 */ public GcFilename FilenameSdr;
        [NMS(Index = 3)]
        /* 0x40 */ public float FadeDistance;
        [NMS(Index = 5)]
        /* 0x44 */ public float HdrAreaAdjust;
        [NMS(Index = 4)]
        /* 0x48 */ public bool SelectableInPhotoMode;
    }
}
