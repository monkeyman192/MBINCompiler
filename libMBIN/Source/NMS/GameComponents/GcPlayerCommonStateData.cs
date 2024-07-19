using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44DDB7C75CFC1FE0, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x3490 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x4E98 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x5048 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x51C0 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 12)]
        /* 0x51D0 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x51E0 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x51E8 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x51F0 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5270 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5271 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x5272 */ public bool UsesThirdPersonVehicleCam;
    }
}
