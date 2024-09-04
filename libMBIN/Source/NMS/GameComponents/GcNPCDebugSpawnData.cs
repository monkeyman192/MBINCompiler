using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA552D146B16FDB49, NameHash = 0xBEE8D99B)]
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
        /* 0x238 */ public GcPetCustomisationData PetAccessoryCustomisation;
        [NMS(Index = 17)]
        /* 0x370 */ public GcResourceElement PropResource;
        [NMS(Index = 7)]
        /* 0x3B8 */ public List<NMSString0x10> Idles;
        [NMS(Index = 16)]
        /* 0x3C8 */ public GcSeed PropSeed;
        [NMS(Index = 11)]
        /* 0x3D8 */ public GcSeed Seed;
        [NMS(Index = 5)]
        /* 0x3E8 */ public List<Vector3f> Waypoints;
        // size: 0x2
        public enum DebugNPCBehaviourEnum : uint {
            None,
            Fishing,
        }
        [NMS(Index = 18)]
        /* 0x3F8 */ public DebugNPCBehaviourEnum DebugNPCBehaviour;
        [NMS(Index = 4)]
        /* 0x3FC */ public float InitialDelay;
        [NMS(Index = 13)]
        /* 0x400 */ public float PetFollowOffset;
        [NMS(Index = 10)]
        /* 0x404 */ public GcAlienRace Race;
        [NMS(Index = 12)]
        /* 0x408 */ public bool AddPetAccessories;
        [NMS(Index = 3)]
        /* 0x409 */ public bool FollowWaypoints;
        [NMS(Index = 6)]
        /* 0x40A */ public bool PlayIdles;
        [NMS(Index = 9)]
        /* 0x40B */ public bool RidePet;
        [NMS(Index = 8)]
        /* 0x40C */ public bool Run;
    }
}
