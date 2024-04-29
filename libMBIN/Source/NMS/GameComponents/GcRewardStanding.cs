using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FA2D149C4251F2B, NameHash = 0x3E2901921A11B02D)]
    public class GcRewardStanding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x8 */ public GcAlienRace Race;
        [NMS(Index = 3)]
        /* 0xC */ public bool UseExpeditionEventSystemRace;
    }
}
