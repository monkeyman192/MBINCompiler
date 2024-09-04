using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A5ECCC5132F1898, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x3498 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x4EA0 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x5050 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x51C8 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 12)]
        /* 0x51D8 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x51E8 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x51F0 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x51F8 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5278 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5279 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x527A */ public bool UsesThirdPersonVehicleCam;
    }
}
