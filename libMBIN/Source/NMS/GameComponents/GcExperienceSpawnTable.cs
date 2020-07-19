using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0xC17E7E9B49178CEB, NameHash = 0x5F4CA33999F0D259)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        /* 0x000 */ public List<GcAIShipSpawnData> FlybySpawns;
        /* 0x010 */ public List<GcAIShipSpawnData> OutpostSpawns;
        /* 0x020 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        /* 0x030 */ public List<GcAIShipSpawnData> PirateSpawns;
        /* 0x040 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        /* 0x050 */ public List<GcAIShipSpawnData> PoliceSpawns;
        /* 0x060 */ public List<GcAIShipSpawnData> TraderSpawns;
        /* 0x070 */ public List<GcAIShipSpawnData> AmbientSpawns;
        /* 0x080 */ public List<GcAIShipSpawnData> BattleSpawns;
        /* 0x090 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        /* 0x0A0 */ public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        /* 0x0B0 */ public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        /* 0x0C0 */ public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        /* 0x0D0 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        /* 0x0E0 */ public List<GcPulseEncounterInfo> PulseEncounters;
        /* 0x0F0 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        /* 0x100 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
    }
}
