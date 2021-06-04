using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xA9A7071266847699, NameHash = 0x902E6B8A4F1B75A6)]
    public class GcExperienceDebugTriggerActionTypes : NMSTemplate
    {
         // size: 0x22
        public enum ExperienceDebugTriggerActionTypesEnum {
            None, Drones, FlyBy, PirateCargoAttack, FreighterAttack, SpawnShips, LaunchShips, Mechs, SpaceBattle, RespawnInShip,
            DebugWalker, DebugWalkerTitanFall, SpawnNexus, Freighters, NPCs, Sandworm, SpacePOI, Creatures, CameraPath, SummonFleet,
            ResetScene, ResetPlayerPos, CameraSpin, SpawnEnemyShips, PetHappy, PetSad, PetFollow, PetFollowClose, PetRest, PetNatural,
            PetMine, PetMineAndDeposit, RidePet, Normandy
        }
        public ExperienceDebugTriggerActionTypesEnum ExperienceDebugTriggerAction;
   }
}
