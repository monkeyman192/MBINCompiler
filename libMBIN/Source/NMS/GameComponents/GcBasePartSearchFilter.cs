using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8371901F5FB58E2, NameHash = 0x80F31719)]
    public class GcBasePartSearchFilter : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 IsSpecificID;
        [NMS(Index = 6)]
        /* 0x10 */ public GcBaseGridSearchFilter BaseGridFilter;
        [NMS(Index = 5)]
        /* 0x3C */ public bool ApplyGridFilter;
        [NMS(Index = 2)]
        /* 0x3D */ public bool PartIsNotOnline;
        [NMS(Index = 4)]
        /* 0x3E */ public bool PartIsNotVision;
        [NMS(Index = 1)]
        /* 0x3F */ public bool PartIsOnline;
        [NMS(Index = 3)]
        /* 0x40 */ public bool PartIsVision;
    }
}
