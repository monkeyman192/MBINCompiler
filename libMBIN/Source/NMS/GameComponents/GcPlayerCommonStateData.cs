using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44CA5C249FC70AB2, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x6E80 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x8888 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x8A60 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x8BE0 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x8BF0 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x8C00 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x8C10 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x8C18 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x8C20 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x8CA0 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x8CA1 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x8CA2 */ public bool UsesThirdPersonVehicleCam;
    }
}
