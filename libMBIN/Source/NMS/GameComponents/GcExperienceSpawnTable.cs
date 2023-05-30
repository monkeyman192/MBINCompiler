using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcExperienceSpawnTable : NMSTemplate
    {
        public List<GcAIShipSpawnData> FlybySpawns;
        public List<GcAIShipSpawnData> OutpostSpawns;
        public List<GcAIShipSpawnData> SpaceFlybySpawns;
        public List<GcAIShipSpawnData> PirateSpawns;
        public List<GcAIShipSpawnData> PirateBattleSpawns;
        public List<GcAIShipSpawnData> PirateBountySpawns;
        public List<GcAIShipSpawnData> PoliceSpawns;
        public List<GcAIShipSpawnData> TraderSpawns;
        public List<GcAIShipSpawnData> AmbientSpawns;
        public List<GcAIShipSpawnData> BattleSpawns;
        public List<GcAIShipSpawnData> InitialBattlePirateSpawns;
        public List<GcAIShipSpawnData> InitialBattleStandardSpawns;
    }
}
