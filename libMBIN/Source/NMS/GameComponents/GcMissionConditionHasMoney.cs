using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD2D419EABB1F47E, NameHash = 0x3BA25965)]
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x4 */ public GcCurrency TestCurrency;
        [NMS(Index = 2)]
        /* 0x8 */ public bool ApplyDifficultyScaling;
    }
}
