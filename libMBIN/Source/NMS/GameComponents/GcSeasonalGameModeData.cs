using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7FA157ED8E92FC85, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x0000 */ public int SeasonId;
        /* 0x0008 */ public ulong StartTimeUTC;
        /* 0x0010 */ public ulong EndTimeUTC;
        /* 0x0018 */ public ulong Hash;
        /* 0x0020 */ public NMSString0x20 Title;
        /* 0x0040 */ public NMSString0x20 Subtitle;
        /* 0x0060 */ public NMSString0x20 Description;
        /* 0x0080 */ public NMSString0x20A FinalStageTitle;
        /* 0x00A0 */ public NMSString0x20A MilestoneWithStageLocId;
        /* 0x00C0 */ public GcGameMode GameMode;
        /* 0x00C4 */ public NMSString0x20 SeasonalUAOverride;
        /* 0x00E8 */ public ulong UAOverrideValue;
        /* 0x00F0 */ public NMSString0x10 FinalReward;
        /* 0x0100 */ public NMSString0x20A FinalCantRewardMessage;
        /* 0x0120 */ public NMSString0x200 FinalRewardDescription;
        /* 0x0320 */ public TkTextureResource MainIcon;
        /* 0x03A4 */ public int SeasonNumber;
        /* 0x03A8 */ public int RemixNumber;
        /* 0x03AC */ public int DisplayNumber;
        /* 0x03B0 */ public NMSString0x20A SeasonName;
        /* 0x03D0 */ public NMSString0x20A SeasonNameUpper;
        /* 0x03F0 */ public NMSString0x20A MainMissionTitle;
        /* 0x0410 */ public NMSString0x20A MainMissionMessage;
        /* 0x0430 */ public bool DoCommunityMissionTextSubstitutions;
        /* 0x0431 */ public bool DefaultToPvPOff;
        /* 0x0438 */ public List<NMSString0x10> AdditionalTradeProducts;
        /* 0x0448 */ public int StartingSuitSlots;
        /* 0x044C */ public int StartingSuitTechSlots;
        /* 0x0450 */ public int StartingSuitCargoSlots;
        /* 0x0458 */ public GcSeed WeaponSeed;
        /* 0x0468 */ public GcSeed ShipSeed;
        /* 0x0478 */ public GcSpaceshipClasses ShipType;
        /* 0x047C */ public bool StartWithFreighter;
        /* 0x047D */ public NMSString0x80 FreighterBaseOverrideFilename;
        /* 0x0500 */ public GcAlienRace FreighterRace;
        /* 0x0504 */ public bool StartAboardFreighter;
        /* 0x0508 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        /* 0x0518 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x0538 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x0558 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x0578 */ public bool UseDefaultAppearance;
        /* 0x0580 */ public GcInventoryContainer Inventory;
        /* 0x06E0 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x0840 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x09A0 */ public GcInventoryContainer ShipInventory;
        /* 0x0B00 */ public GcInventoryContainer WeaponInventory;
        /* 0x0C60 */ public bool UseRandomPet;
        /* 0x0C68 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Size = 0x12)]
        /* 0x0C78 */ public GcPetData[] SpecificPets;
        /* 0x32B8 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        /* 0x32C8 */ public bool SandwormGlobalOverride;
        /* 0x32CC */ public float SandwormGlobalOverrideTimer;
        /* 0x32D0 */ public float SandwormGlobalOverrideSpawnChance;
        /* 0x32D4 */ public bool StartNextToShip;
        /* 0x32D8 */ public float DistanceFromShipAtStartOfGame;
        /* 0x32DC */ public bool ShipStartsDamaged;
        /* 0x32DD */ public bool AllowMissionDetailMessages;
        /* 0x32DE */ public bool UseStartPlanetObjectListOverrides;
        /* 0x32E0 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        /* 0x32F0 */ public bool TrashInventoryOnGalaxyTravel;
        /* 0x32F4 */ public int FreighterBattleEarlyWarpsOverride;
        /* 0x32F8 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        /* 0x32FC */ public int TechCostMultiplier;
        /* 0x3300 */ public List<NMSString0x10> NeverLearnableTech;
        /* 0x3310 */ public List<NMSString0x10> ForgottenProducts;
        /* 0x3320 */ public bool IncreaseXClassTechOddsWithCommTier;
        /* 0x3324 */ public float AbandonedFreighterHazardProtectionMul;
        /* 0x3328 */ public int QuestSubstanceReducer;
        /* 0x3330 */ public List<GcSeasonalStage> Stages;
        /* 0x3340 */ public GcScanEventTable ScanEventTable;
        /* 0x3350 */ public bool ResetSaveOnDeath;
        /* 0x3358 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        /* 0x3368 */ public bool CompatibleWithState;
        /* 0x3369 */ public bool HasBeenConverted;
    }
}
