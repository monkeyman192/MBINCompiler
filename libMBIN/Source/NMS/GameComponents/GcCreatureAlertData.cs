using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x9C0901BDD017D265, NameHash = 0xFFF2D3D18F84C008)]
    public class GcCreatureAlertData : NMSTemplate
    {
        /* 0x000 */ public GcCreatureTypes AlertTarget;
		/* 0x004 */ public GcCreatureTypes AlertInitiator;
		/* 0x008 */ public float HearingRange;              // 42C80000h
		/* 0x00C */ public float SightRange;                // 43160000h
		/* 0x010 */ public float SightAngle;                // 42700000h
		/* 0x014 */ public float FleeRange;                 // 41700000h
    }
}
