using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA47667DBE7F81CC1, NameHash = 0xBEE8D99B)]
    public class GcNPCDebugSpawnData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public Vector3f Facing;
        [NMS(Index = 0)]
        /* 0x010 */ public Vector3f Position;
        [NMS(Index = 2)]
        /* 0x020 */ public Vector3f Up;
        [NMS(Index = 14)]
        /* 0x030 */ public GcPetData Pet;
        [NMS(Index = 15)]
        /* 0x328 */ public GcPetCustomisationData PetAccessoryCustomisation;
        [NMS(Index = 17)]
        /* 0x460 */ public GcResourceElement PropResource;
        [NMS(Index = 7)]
        /* 0x4A8 */ public List<NMSString0x10> Idles;
        [NMS(Index = 16)]
        /* 0x4B8 */ public GcSeed PropSeed;
        [NMS(Index = 11)]
        /* 0x4C8 */ public GcSeed Seed;
        [NMS(Index = 5)]
        /* 0x4D8 */ public List<Vector3f> Waypoints;
        // size: 0x2
        public enum DebugNPCBehaviourEnum : uint {
            None,
            Fishing,
        }
        [NMS(Index = 18)]
        /* 0x4E8 */ public DebugNPCBehaviourEnum DebugNPCBehaviour;
        [NMS(Index = 4)]
        /* 0x4EC */ public float InitialDelay;
        [NMS(Index = 13)]
        /* 0x4F0 */ public float PetFollowOffset;
        [NMS(Index = 10)]
        /* 0x4F4 */ public GcAlienRace Race;
        [NMS(Index = 12)]
        /* 0x4F8 */ public bool AddPetAccessories;
        [NMS(Index = 3)]
        /* 0x4F9 */ public bool FollowWaypoints;
        [NMS(Index = 6)]
        /* 0x4FA */ public bool PlayIdles;
        [NMS(Index = 9)]
        /* 0x4FB */ public bool RidePet;
        [NMS(Index = 8)]
        /* 0x4FC */ public bool Run;
    }
}
