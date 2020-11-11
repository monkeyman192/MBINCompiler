using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x6C5ACA38FC76938E, NameHash = 0x902E6B8A4F1B75A6)]
    public class GcExperienceDebugTriggerActionTypes : NMSTemplate
    {
         // 0x17 entries
        public enum ExperienceDebugTriggerActionTypesEnum {
            None, Drones, FlyBy, PirateCargoAttack, FreighterAttack, SpawnShips, LaunchShips, Mechs, SpaceBattle, RespawnInShip,
            DebugWalker, SpawnNexus, Freighters, NPCs, Sandworm, SpacePOI, Creatures, CameraPath, SummonFleet, ResetScene,
            ResetPlayerPos, CameraSpin, SpawnEnemyShips
        }
        public ExperienceDebugTriggerActionTypesEnum ExperienceDebugTriggerAction;
   }
}
