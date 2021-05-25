using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x498, GUID = 0x82EDCC2C4DAB7F03, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x000 */ public int SeasonId;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        /* 0x008 */ public ulong StartTimeUTC;
        /* 0x010 */ public ulong EndTimeUTC;
        /* 0x018 */ public ulong Hash;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x040 */ public string Subtitle;
        [NMS(Size = 0x20)]
        /* 0x060 */ public string Description;
        /* 0x080 */ public GcGameMode GameMode;
        [NMS(Size = 0x20)]
        /* 0x084 */ public string SeasonalUAOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0A4 */ public byte[] PaddingA4;
        /* 0x0A8 */ public ulong UAOverrideValue;
        [NMS(Size = 0x10)]
        /* 0x0B0 */ public string FinalReward;
        [NMS(Size = 0x200)]
        /* 0x0C0 */ public string FinalRewardDescription;
        /* 0x2C0 */ public TkTextureResource MainIcon;
        /* 0x344 */ public int SeasonNumber;
        [NMS(Size = 0x20)]
        /* 0x348 */ public string SeasonName;
        [NMS(Size = 0x20)]
        /* 0x368 */ public string SeasonNameUpper;
        [NMS(Size = 0x20)]
        /* 0x388 */ public string MainMissionTitle;  // Aligned
        [NMS(Size = 0x20)]
        /* 0x3A8 */ public string MainMissionMessage;  // Aligned
        /* 0x3C8 */ public int StartingSuitSlots;
        /* 0x3CC */ public int StartingSuitTechSlots;
        /* 0x3D0 */ public int StartingSuitCargoSlots;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3D4 */ public byte[] Padding3D4;
        /* 0x3D8 */ public GcSeed WeaponSeed;
        /* 0x3E8 */ public GcSeed ShipSeed;
        /* 0x3F8 */ public GcSpaceshipClasses ShipType;
        /* 0x3FC */ public bool StartWithFreighter;
        /* 0x400 */ public GcAlienRace FreighterRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x404 */ public byte[] Padding404;
        /* 0x408 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x428 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x448 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x468 */ public bool UseDefaultAppearance;
        /* 0x469 */ public bool StartNextToShip;
        /* 0x46C */ public float DistanceFromShipAtStartOfGame;
        /* 0x470 */ public bool ShipStartsDamaged;
        /* 0x471 */ public bool AllowMissionDetailMessages;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x472 */ public byte[] Padding472;
        /* 0x478 */ public List<GcSeasonalStage> Stages;
        /* 0x488 */ public GcScanEventTable ScanEventTable;
    }
}
