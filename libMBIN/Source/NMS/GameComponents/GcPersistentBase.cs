using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x856B1B2F38F87437, NameHash = 0x732552199A3AE45E)]
    public class GcPersistentBase : NMSTemplate
    {
        /* 0x000 */ public Vector3f Forward;
        /* 0x010 */ public Vector3f Position;
        /* 0x020 */ public Vector3f ScreenshotAt;
        /* 0x030 */ public Vector3f ScreenshotPos;
        /* 0x040 */ public List<GcPersistentBaseEntry> Objects;
        /* 0x050 */ public ulong GalacticAddress;
        /* 0x058 */ public ulong LastUpdateTimestamp;
        /* 0x060 */ public ulong UserData;
        /* 0x068 */ public GcDiscoveryOwner Owner;
        /* 0x16C */ public GcPersistentBaseDifficultyData Difficulty;
        /* 0x174 */ public GcBaseAutoPowerSetting AutoPowerSetting;
        /* 0x178 */ public GcPersistentBaseTypes BaseType;
        /* 0x17C */ public int BaseVersion;
        /* 0x180 */ public GcGameMode GameMode;
        /* 0x184 */ public int OriginalBaseVersion;
        /* 0x188 */ public NMSString0x40 LastEditedById;
        /* 0x1C8 */ public NMSString0x40 LastEditedByUsername;
        /* 0x208 */ public NMSString0x40 Name;
        /* 0x248 */ public NMSString0x40 RID;
        /* 0x288 */ public NMSString0x20 PlatformToken;
        /* 0x2A8 */ public bool IsFeatured;
        /* 0x2A9 */ public bool IsReported;
    }
}
