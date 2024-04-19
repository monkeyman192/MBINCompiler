using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7177110DFC9D0A2D, NameHash = 0x4C060D5780D187B4)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        /* 0x0000 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x0050 */ public GcSeasonalGameModeData SeasonData;
        /* 0x3638 */ public GcByteBeatLibraryData ByteBeatLibrary;
        /* 0x5040 */ public GcSeasonStateData SeasonState;
        /* 0x51F0 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        /* 0x5368 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
        /* 0x5378 */ public ulong TotalPlayTime;
        /* 0x5380 */ public NMSString0x80 SaveName;
        /* 0x5400 */ public bool UsesThirdPersonCharacterCam;
        /* 0x5401 */ public bool UsesThirdPersonShipCam;
        /* 0x5402 */ public bool UsesThirdPersonVehicleCam;
    }
}
