using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0x1046A908E8441CE4, NameHash = 0xBDA9289A7DF468BD)]
    public class GcMissionSequenceDoMissionsForFaction : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        /* 0x080 */ public GcFactionSelectOptions SelectFrom;

        /* 0x088 */ public int AmountMine;
        /* 0x08C */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
