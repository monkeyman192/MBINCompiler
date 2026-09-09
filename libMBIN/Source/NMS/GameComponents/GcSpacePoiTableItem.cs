using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD79CBEB97C33D190, NameHash = 0x3C8DAB48)]
    public class GcSpacePoiTableItem : NMSTemplate
    {
        [NMS(Index = 34)]
        /* 0x000 */ public NMSString0x20A CompleteMapDescriptionOverride;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A NameLocId;
        [NMS(Index = 20)]
        /* 0x040 */ public TkModelResource Scene;
        [NMS(Index = 33)]
        /* 0x060 */ public TkTextureResource CompleteMapIconOverride;
        [NMS(Index = 5)]
        /* 0x078 */ public TkTextureResource MapIconOverride;
        [NMS(Index = 4)]
        /* 0x090 */ public TkTextureResource MarkerIconOverride;
        [NMS(Index = 9)]
        /* 0x0A8 */ public NMSTemplate Behaviour;
        [NMS(Index = 31)]
        /* 0x0B8 */ public List<int> BlockDuringSeasons;
        [NMS(Index = 10)]
        /* 0x0C8 */ public NMSString0x10 EncounterID;
        [NMS(Index = 11)]
        /* 0x0D8 */ public NMSString0x10 EncounterProfileID;
        [NMS(Index = 0)]
        /* 0x0E8 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x0F8 */ public GcFilename MapObjectSceneOverride;
        [NMS(Index = 28)]
        /* 0x108 */ public NMSTemplate SpawnLocation;
        [NMS(Index = 27)]
        /* 0x118 */ public GcSpaceObjectComponentData SpaceObjectData;
        [NMS(Index = 13)]
        /* 0x138 */ public float ActivationDistance;
        [NMS(Index = 26)]
        /* 0x13C */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x140 */ public int GenerationVersion;
        [NMS(Index = 19)]
        /* 0x144 */ public GcSpacePoiDiscoveryLevel InitialDiscoveryLevel;
        [NMS(Index = 14)]
        /* 0x148 */ public float MaxSpacewalkSpeed;
        // size: 0x2
        public enum PostCompleteBehaviourEnum : uint {
            Hide,
            Show,
        }
        [NMS(Index = 32)]
        /* 0x14C */ public PostCompleteBehaviourEnum PostCompleteBehaviour;
        // size: 0x5
        public enum PulseApproachEnum : uint {
            Off,
            Horizon,
            Direction,
            DirectionBelowHorizon,
            LookAbove,
        }
        [NMS(Index = 15)]
        /* 0x150 */ public PulseApproachEnum PulseApproach;
        [NMS(Index = 12)]
        /* 0x154 */ public float PulseDisengageDistance;
        [NMS(Index = 23)]
        /* 0x158 */ public float SpawnDistance;
        [NMS(Index = 22)]
        /* 0x15C */ public float SpawnRadius;
        [NMS(Index = 21)]
        /* 0x160 */ public float SpawnScale;
        [NMS(Index = 8)]
        /* 0x164 */ public float TrackArrowInsidePOIMinRadius;
        [NMS(Index = 2)]
        /* 0x168 */ public GcSpacePoiType Type;
        [NMS(Index = 30)]
        /* 0x16C */ public bool AllowedInAbandonedSystem;
        [NMS(Index = 29)]
        /* 0x16D */ public bool AllowedInEmptySystem;
        [NMS(Index = 16)]
        /* 0x16E */ public bool IsDiscovery;
        [NMS(Index = 24)]
        /* 0x16F */ public bool IsFloatingIsland;
        [NMS(Index = 18)]
        /* 0x170 */ public bool RemainHiddenUntilRevealed;
        [NMS(Index = 17)]
        /* 0x171 */ public bool ShowDiscoveryOSDOnArrival;
        [NMS(Index = 7)]
        /* 0x172 */ public bool ShowTrackingArrowsInsidePoi;
        [NMS(Index = 25)]
        /* 0x173 */ public bool UseSpaceUpAsSpawnUp;
    }
}
