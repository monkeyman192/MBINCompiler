using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1A0E2DE6B0623BB, NameHash = 0x1D427C136EB50E9D)]
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
        [NMS(Index = 7)]
        /* 0x340 */ public List<NMSString0x10> Idles;
        [NMS(Index = 11)]
        /* 0x350 */ public GcSeed Seed;
        [NMS(Index = 5)]
        /* 0x360 */ public List<Vector3f> Waypoints;
        [NMS(Index = 4)]
        /* 0x370 */ public float InitialDelay;
        [NMS(Index = 13)]
        /* 0x374 */ public float PetFollowOffset;
        [NMS(Index = 10)]
        /* 0x378 */ public GcAlienRace Race;
        [NMS(Index = 12)]
        /* 0x37C */ public bool AddPetAccessories;
        [NMS(Index = 3)]
        /* 0x37D */ public bool FollowWaypoints;
        [NMS(Index = 6)]
        /* 0x37E */ public bool PlayIdles;
        [NMS(Index = 9)]
        /* 0x37F */ public bool RidePet;
        [NMS(Index = 8)]
        /* 0x380 */ public bool Run;
    }
}
