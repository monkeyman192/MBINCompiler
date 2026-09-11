using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x344B87ECC0D1CF91, NameHash = 0xC7D918F3)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x6BF0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x85F8 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x87D0 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x8950 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 13)]
        /* 0x8960 */ public List<GcDiscoveryOwner> UsedDiscoveryOwnersV2;
        [NMS(Index = 12)]
        /* 0x8970 */ public List<NMSString0x20> UsedPlatforms;
        [NMS(Index = 11)]
        /* 0x8980 */ public ulong SaveUniversalId;
        [NMS(Index = 1)]
        /* 0x8988 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x8990 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x8A10 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x8A11 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x8A12 */ public bool UsesThirdPersonVehicleCam;
    }
}
