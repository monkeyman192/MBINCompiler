using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x561705883B3C2556, NameHash = 0x1CD96DF6BD8E239C)]
    public class GcFleetExpeditionSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public ulong UA;
        /* 0x020 */ public Vector3f SpawnPosition;
        /* 0x030 */ public Vector3f TerminalPosition;
        /* 0x040 */ public float SpeedMultiplier;
        /* 0x048 */ public List<NMSString0x10> Powerups;
        /* 0x058 */ public NMSString0x100 CustomName;
        /* 0x158 */ public NMSString0x10 InterventionEventMissionID;
        /* 0x168 */ public ulong StartTime;
        /* 0x170 */ public ulong PauseTime;
        /* 0x178 */ public ulong TimeOfLastUAChange;
        /* 0x180 */ public int NextEventToTrigger;
        /* 0x184 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x188 */ public GcExpeditionDuration ExpeditionDuration;
        /* 0x190 */ public List<int> ActiveFrigateIndices;
        /* 0x1A0 */ public List<int> DamagedFrigateIndices;
        /* 0x1B0 */ public List<int> DestroyedFrigateIndices;
        /* 0x1C0 */ public List<int> AllFrigateIndices;
        /* 0x1D0 */ public int NumberOfSuccessfulEventsThisExpedition;
        /* 0x1D4 */ public int NumberOfFailedEventsThisExpedition;
        /* 0x1D8 */ public List<GcExpeditionEventSaveData> Events;
        /* 0x1E8 */ public bool InterventionPhoneCallActivated;
    }
}
