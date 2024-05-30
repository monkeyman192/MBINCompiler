namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2DD8AF8F537AC4A, NameHash = 0x902E6B8A4F1B75A6)]
    public class GcExperienceDebugTriggerActionTypes : NMSTemplate
    {
        // size: 0x33
        public enum ExperienceDebugTriggerActionEnum : uint {
            None,
            Drones,
            FlyBy,
            FrigateFlyByBegin,
            FrigateFlyByEnd,
            PirateCargoAttack,
            PirateRaid,
            FreighterAttack,
            SpawnShips,
            LaunchShips,
            Mechs,
            SpaceBattle,
            PirateSpaceBattle,
            ClearPirateSpaceBattle,
            RespawnInShip,
            DebugWalker,
            DebugWalkerTitanFall,
            SpawnNexus,
            Freighters,
            NPCs,
            Sandworm,
            SpacePOI,
            BackgroundSpaceEncounter,
            Creatures,
            CameraPath,
            SummonFleet,
            SummonSquadron,
            ResetScene,
            ResetPlayerPos,
            CameraSpin,
            SpawnEnemyShips,
            PetHappy,
            PetSad,
            PetFollow,
            PetFollowClose,
            PetRest,
            PetNatural,
            PetMine,
            PetMineAndDeposit,
            RidePet,
            GhostShip,
            Normandy,
            LivingFrigate,
            UpgradeSettlement,
            SentinelFreighter,
            ClearSpacePolice,
            SpawnQuad,
            SpawnSpiderQuad,
            SpawnSpiderQuadMini,
            SpawnDockedShips,
            LaunchDockedShips,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ExperienceDebugTriggerActionEnum ExperienceDebugTriggerAction;
    }
}
