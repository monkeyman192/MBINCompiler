using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F0, GUID = 0x4CB3ED5D550DACB8, NameHash = 0x1CD96DF6BD8E239C)]
    public class GcFleetExpeditionSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed ResourceSeed;
        /* 0x010 */ public ulong UA;
        /* 0x020 */ public Vector3f SpawnPosition;
        /* 0x030 */ public Vector3f TerminalPosition;
        /* 0x040 */ public float SpeedMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x044 */ public byte[] Padding44;
        /* 0x048 */ public List<NMSString0x10> Powerups;
        /* 0x058 */ public NMSString0x100 CustomName;
        /* 0x158 */ public NMSString0x10 InterventionEventMissionID;
        /* 0x168 */ public ulong StartTime;
        /* 0x170 */ public ulong PauseTime;
        /* 0x178 */ public ulong TimeOfLastUAChange;
        /* 0x180 */ public int NextEventToTrigger;
        /* 0x184 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x188 */ public GcExpeditionDuration ExpeditionDuration;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x18C */ public byte[] Padding18C;
        /* 0x190 */ public List<int> ActiveFrigateIndices;
        /* 0x1A0 */ public List<int> DamagedFrigateIndices;
        /* 0x1B0 */ public List<int> DestroyedFrigateIndices;
        /* 0x1C0 */ public List<int> AllFrigateIndices;
        /* 0x1D0 */ public int NumberOfSuccessfulEventsThisExpedition;
        /* 0x1D4 */ public int NumberOfFailedEventsThisExpedition;
        /* 0x1D8 */ public List<GcExpeditionEventSaveData> Events;
        /* 0x1E8 */ public bool InterventionPhoneCallActivated;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1E9 */ public byte[] EndPadding;
    }
}
