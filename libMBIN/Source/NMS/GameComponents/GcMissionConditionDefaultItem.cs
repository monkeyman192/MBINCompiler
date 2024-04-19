using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x638524CFD3C9B5F8, NameHash = 0x6F38B975D5E86126)]
    public class GcMissionConditionDefaultItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public GcDefaultMissionProductEnum ProductType;
        /* 0x14 */ public GcDefaultMissionSubstanceEnum SubstanceType;
    }
}
