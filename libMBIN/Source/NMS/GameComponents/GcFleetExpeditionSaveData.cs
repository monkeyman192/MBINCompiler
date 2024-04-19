using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DA3E565B1BB2288, NameHash = 0x1CD96DF6BD8E239C)]
    public class GcFleetExpeditionSaveData : NMSTemplate
    {
        /* 0x000 */ public Vector3f SpawnPosition;
        /* 0x010 */ public Vector3f TerminalPosition;
        /* 0x020 */ public List<int> ActiveFrigateIndices;
        /* 0x030 */ public List<int> AllFrigateIndices;
        /* 0x040 */ public List<int> DamagedFrigateIndices;
        /* 0x050 */ public List<int> DestroyedFrigateIndices;
        /* 0x060 */ public List<GcExpeditionEventSaveData> Events;
        /* 0x070 */ public NMSString0x10 InterventionEventMissionID;
        /* 0x080 */ public List<NMSString0x10> Powerups;
        /* 0x090 */ public GcSeed Seed;
        /* 0x0A0 */ public ulong PauseTime;
        /* 0x0A8 */ public ulong StartTime;
        /* 0x0B0 */ public ulong TimeOfLastUAChange;
        /* 0x0B8 */ public ulong UA;
        /* 0x0C0 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x0C4 */ public GcExpeditionDuration ExpeditionDuration;
        /* 0x0C8 */ public int NextEventToTrigger;
        /* 0x0CC */ public int NumberOfFailedEventsThisExpedition;
        /* 0x0D0 */ public int NumberOfSuccessfulEventsThisExpedition;
        /* 0x0D4 */ public float SpeedMultiplier;
        /* 0x0D8 */ public NMSString0x100 CustomName;
        /* 0x1D8 */ public bool InterventionPhoneCallActivated;
    }
}
