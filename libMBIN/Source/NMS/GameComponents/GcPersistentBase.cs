using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x856B1B2F38F87437, NameHash = 0x732552199A3AE45E)]
    public class GcPersistentBase : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public Vector3f Forward;
        [NMS(Index = 3)]
        /* 0x010 */ public Vector3f Position;
        [NMS(Index = 14)]
        /* 0x020 */ public Vector3f ScreenshotAt;
        [NMS(Index = 15)]
        /* 0x030 */ public Vector3f ScreenshotPos;
        [NMS(Index = 7)]
        /* 0x040 */ public List<GcPersistentBaseEntry> Objects;
        [NMS(Index = 2)]
        /* 0x050 */ public ulong GalacticAddress;
        [NMS(Index = 6)]
        /* 0x058 */ public ulong LastUpdateTimestamp;
        [NMS(Index = 5)]
        /* 0x060 */ public ulong UserData;
        [NMS(Index = 9)]
        /* 0x068 */ public GcDiscoveryOwner Owner;
        [NMS(Index = 17)]
        /* 0x16C */ public GcPersistentBaseDifficultyData Difficulty;
        [NMS(Index = 21)]
        /* 0x174 */ public GcBaseAutoPowerSetting AutoPowerSetting;
        [NMS(Index = 11)]
        /* 0x178 */ public GcPersistentBaseTypes BaseType;
        [NMS(Index = 0)]
        /* 0x17C */ public int BaseVersion;
        [NMS(Index = 16)]
        /* 0x180 */ public GcGameMode GameMode;
        [NMS(Index = 1)]
        /* 0x184 */ public int OriginalBaseVersion;
        [NMS(Index = 12)]
        /* 0x188 */ public NMSString0x40 LastEditedById;
        [NMS(Index = 13)]
        /* 0x1C8 */ public NMSString0x40 LastEditedByUsername;
        [NMS(Index = 10)]
        /* 0x208 */ public NMSString0x40 Name;
        [NMS(Index = 8)]
        /* 0x248 */ public NMSString0x40 RID;
        [NMS(Index = 18)]
        /* 0x288 */ public NMSString0x20 PlatformToken;
        [NMS(Index = 20)]
        /* 0x2A8 */ public bool IsFeatured;
        [NMS(Index = 19)]
        /* 0x2A9 */ public bool IsReported;
    }
}
