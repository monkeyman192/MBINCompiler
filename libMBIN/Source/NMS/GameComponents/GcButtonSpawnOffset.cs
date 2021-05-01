using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x46CE100A699D46BF, NameHash = 0x42A6687A1AF1F42A)]
    public class GcButtonSpawnOffset : NMSTemplate        // size: 0x20       // in a global?
    {
        /* 0x00 */ public float AngleMin;                   // 0C1F00000h
        /* 0x04 */ public float AngleMax;                   // 41F00000h
        /* 0x08 */ public float Offset;                     // 43480000h
        /* 0x0C */ public float Spacing;                    // 42480000h
        /* 0x10 */ public float Facing;                     // [rdi+10h], eax
        /* 0x14 */ public int Count;                        // 3
        /* 0x18 */ public GcRealityCommonFactions Faction;
        /* 0x1C */ public GcAISpaceshipRoles ShipRole;     // [rdi+1Ch], eax
    }
}