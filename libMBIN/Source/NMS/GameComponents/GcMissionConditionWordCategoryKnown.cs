using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6C9B8DF9C8F66A4, NameHash = 0x52C43072)]
    public class GcMissionConditionWordCategoryKnown : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcWordCategoryTableEnum Category;
        [NMS(Index = 1)]
        /* 0x4 */ public GcAlienRace Race;
    }
}
