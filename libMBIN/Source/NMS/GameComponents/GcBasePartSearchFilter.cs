using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE31DCBB6E6BAA484, NameHash = 0x471C446618668C68)]
    public class GcBasePartSearchFilter : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IsSpecificID;
        /* 0x10 */ public GcBaseGridSearchFilter BaseGridFilter;
        /* 0x3C */ public bool ApplyGridFilter;
        /* 0x3D */ public bool PartIsNotOnline;
        /* 0x3E */ public bool PartIsNotVision;
        /* 0x3F */ public bool PartIsOnline;
        /* 0x40 */ public bool PartIsVision;
    }
}
