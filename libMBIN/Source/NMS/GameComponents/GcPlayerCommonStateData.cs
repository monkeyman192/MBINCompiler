using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7177110DFC9D0A2D, NameHash = 0x4C060D5780D187B4)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        [NMS(Index = 7)]
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        [NMS(Index = 6)]
        /* 0x3638 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Index = 8)]
        /* 0x5040 */ public GcSeasonStateData SeasonState;
        [NMS(Index = 9)]
        /* 0x51F0 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        [NMS(Index = 10)]
        /* 0x5368 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        [NMS(Index = 1)]
        /* 0x5378 */ public ulong TotalPlayTime;
        [NMS(Index = 0)]
        /* 0x5380 */ public NMSString0x80 SaveName;
        [NMS(Index = 2)]
        /* 0x5400 */ public bool UsesThirdPersonCharacterCam;
        [NMS(Index = 4)]
        /* 0x5401 */ public bool UsesThirdPersonShipCam;
        [NMS(Index = 3)]
        /* 0x5402 */ public bool UsesThirdPersonVehicleCam;
    }
}
