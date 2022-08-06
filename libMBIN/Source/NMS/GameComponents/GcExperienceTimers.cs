using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x62C7CA383FB44A6C, NameHash = 0x7DF5AD147C5460A0)]
    public class GcExperienceTimers : NMSTemplate
    {
	  /* 0x00 */ public int HighChance;         // 0Ah
	  /* 0x04 */ public int LowChance;          // 1Eh
	  /* 0x08 */ public Vector2f High;          // 41F00000h x2
	  /* 0x10 */ public Vector2f Normal;        // 42700000h x2
	  /* 0x18 */ public Vector2f Low;           // 42F00000h x2
    }
}