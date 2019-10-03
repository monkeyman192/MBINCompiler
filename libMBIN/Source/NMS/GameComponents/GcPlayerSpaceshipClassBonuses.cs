using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x9E42C06E5A1542B3, NameHash = 0xFA78E3D1251A147D)]
    public class GcPlayerSpaceshipClassBonuses : NMSTemplate
    {
        /* 0x00 */ public float ThrustForceMax;         // 42480000h
        /* 0x04 */ public float ThrustForceMin;
        /* 0x08 */ public float MaxSpeedMax;            // 40A00000h
        /* 0x0C */ public float MaxSpeedMin;
        /* 0x10 */ public float BoostMaxSpeedMax;       // 40A00000h
        /* 0x14 */ public float BoostMaxSpeedMin;
        /* 0x18 */ public float BoostingTurnDampMax;    // 3D4CCCCDh
        /* 0x1C */ public float BoostingTurnDampMin;    // 0BD4CCCCDh
        /* 0x20 */ public float DirectionBrakeMin;      // 3E4CCCCDh
        /* 0x24 */ public float DirectionBrakeMax;      // 0BE4CCCCDh
        /* 0x28 */ public float TurnStrengthMax;        // 3DCCCCCDh
        /* 0x2C */ public float TurnStrengthMin;
    }
}
