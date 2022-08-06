using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6C1413034865F16, NameHash = 0x902E6B8A4F1B75A6)]
    public class GcExperienceDebugTriggerActionTypes : NMSTemplate
    {
        // size: 0x29
        public enum ExperienceDebugTriggerActionEnum {
            None, Drones, FlyBy, FrigateFlyByBegin, FrigateFlyByEnd, PirateCargoAttack,
            PirateRaid, FreighterAttack, SpawnShips, LaunchShips, Mechs, SpaceBattle,
            RespawnInShip, DebugWalker, DebugWalkerTitanFall, SpawnNexus, Freighters,
            NPCs, Sandworm, SpacePOI, BackgroundSpaceEncounter, Creatures,
            CameraPath, SummonFleet, SummonSquadron, ResetScene, ResetPlayerPos,
            CameraSpin, SpawnEnemyShips, PetHappy, PetSad, PetFollow, PetFollowClose,
            PetRest, PetNatural, PetMine, PetMineAndDeposit, RidePet, Normandy,
            LivingFrigate, UpgradeSettlement
        }
        /* 0x0 */ public ExperienceDebugTriggerActionEnum ExperienceDebugTriggerAction;
    }
}
