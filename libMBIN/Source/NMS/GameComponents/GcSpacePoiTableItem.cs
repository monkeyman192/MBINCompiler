using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9A86DBF768D530F, NameHash = 0x3C8DAB48)]
    public class GcSpacePoiTableItem : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x20A NameLocId;
        [NMS(Index = 19)]
        /* 0x020 */ public TkModelResource Scene;
        [NMS(Index = 5)]
        /* 0x040 */ public TkTextureResource MapIconOverride;
        [NMS(Index = 4)]
        /* 0x058 */ public TkTextureResource MarkerIconOverride;
        [NMS(Index = 9)]
        /* 0x070 */ public NMSTemplate Behaviour;
        [NMS(Index = 30)]
        /* 0x080 */ public List<int> BlockDuringSeasons;
        [NMS(Index = 10)]
        /* 0x090 */ public NMSString0x10 EncounterID;
        [NMS(Index = 11)]
        /* 0x0A0 */ public NMSString0x10 EncounterProfileID;
        [NMS(Index = 0)]
        /* 0x0B0 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x0C0 */ public GcFilename MapObjectSceneOverride;
        [NMS(Index = 27)]
        /* 0x0D0 */ public NMSTemplate SpawnLocation;
        [NMS(Index = 26)]
        /* 0x0E0 */ public GcSpaceObjectComponentData SpaceObjectData;
        [NMS(Index = 13)]
        /* 0x100 */ public float ActivationDistance;
        [NMS(Index = 25)]
        /* 0x104 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x108 */ public int GenerationVersion;
        [NMS(Index = 18)]
        /* 0x10C */ public GcSpacePoiDiscoveryLevel InitialDiscoveryLevel;
        // size: 0x5
        public enum PulseApproachEnum : uint {
            Off,
            Horizon,
            Direction,
            DirectionBelowHorizon,
            LookAbove,
        }
        [NMS(Index = 14)]
        /* 0x110 */ public PulseApproachEnum PulseApproach;
        [NMS(Index = 12)]
        /* 0x114 */ public float PulseDisengageDistance;
        [NMS(Index = 22)]
        /* 0x118 */ public float SpawnDistance;
        [NMS(Index = 21)]
        /* 0x11C */ public float SpawnRadius;
        [NMS(Index = 20)]
        /* 0x120 */ public float SpawnScale;
        [NMS(Index = 8)]
        /* 0x124 */ public float TrackArrowInsidePOIMinRadius;
        [NMS(Index = 2)]
        /* 0x128 */ public GcSpacePoiType Type;
        [NMS(Index = 29)]
        /* 0x12C */ public bool AllowedInAbandonedSystem;
        [NMS(Index = 28)]
        /* 0x12D */ public bool AllowedInEmptySystem;
        [NMS(Index = 15)]
        /* 0x12E */ public bool IsDiscovery;
        [NMS(Index = 23)]
        /* 0x12F */ public bool IsFloatingIsland;
        [NMS(Index = 17)]
        /* 0x130 */ public bool RemainHiddenUntilRevealed;
        [NMS(Index = 16)]
        /* 0x131 */ public bool ShowDiscoveryOSDOnArrival;
        [NMS(Index = 7)]
        /* 0x132 */ public bool ShowTrackingArrowsInsidePoi;
        [NMS(Index = 31)]
        /* 0x133 */ public bool StaysAroundAfterCompletion;
        [NMS(Index = 24)]
        /* 0x134 */ public bool UseSpaceUpAsSpawnUp;
    }
}
