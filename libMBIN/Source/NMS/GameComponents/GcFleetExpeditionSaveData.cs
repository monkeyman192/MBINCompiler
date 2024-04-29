using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1838E4CE316473B6, NameHash = 0x1CD96DF6BD8E239C)]
    public class GcFleetExpeditionSaveData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public Vector3f SpawnPosition;
        [NMS(Index = 3)]
        /* 0x010 */ public Vector3f TerminalPosition;
        [NMS(Index = 14)]
        /* 0x020 */ public List<int> ActiveFrigateIndices;
        [NMS(Index = 17)]
        /* 0x030 */ public List<int> AllFrigateIndices;
        [NMS(Index = 15)]
        /* 0x040 */ public List<int> DamagedFrigateIndices;
        [NMS(Index = 16)]
        /* 0x050 */ public List<int> DestroyedFrigateIndices;
        [NMS(Index = 20)]
        /* 0x060 */ public List<GcExpeditionEventSaveData> Events;
        [NMS(Index = 7)]
        /* 0x070 */ public NMSString0x10 InterventionEventMissionID;
        [NMS(Index = 5)]
        /* 0x080 */ public List<NMSString0x10> Powerups;
        [NMS(Index = 0)]
        /* 0x090 */ public GcSeed Seed;
        [NMS(Index = 9)]
        /* 0x0A0 */ public ulong PauseTime;
        [NMS(Index = 8)]
        /* 0x0A8 */ public ulong StartTime;
        [NMS(Index = 10)]
        /* 0x0B0 */ public ulong TimeOfLastUAChange;
        [NMS(Index = 1)]
        /* 0x0B8 */ public ulong UA;
        [NMS(Index = 12)]
        /* 0x0C0 */ public GcExpeditionCategory ExpeditionCategory;
        [NMS(Index = 13)]
        /* 0x0C4 */ public GcExpeditionDuration ExpeditionDuration;
        [NMS(Index = 11)]
        /* 0x0C8 */ public int NextEventToTrigger;
        [NMS(Index = 19)]
        /* 0x0CC */ public int NumberOfFailedEventsThisExpedition;
        [NMS(Index = 18)]
        /* 0x0D0 */ public int NumberOfSuccessfulEventsThisExpedition;
        [NMS(Index = 4)]
        /* 0x0D4 */ public float SpeedMultiplier;
        [NMS(Index = 6)]
        /* 0x0D8 */ public NMSString0x100 CustomName;
        [NMS(Index = 21)]
        /* 0x1D8 */ public bool InterventionPhoneCallActivated;
    }
}
