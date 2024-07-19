using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81D101B0BE1541AE, NameHash = 0xBEE8D99B)]
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
        /* 0x370 */ public List<NMSString0x10> Idles;
        [NMS(Index = 11)]
        /* 0x380 */ public GcSeed Seed;
        [NMS(Index = 5)]
        /* 0x390 */ public List<Vector3f> Waypoints;
        [NMS(Index = 4)]
        /* 0x3A0 */ public float InitialDelay;
        [NMS(Index = 13)]
        /* 0x3A4 */ public float PetFollowOffset;
        [NMS(Index = 10)]
        /* 0x3A8 */ public GcAlienRace Race;
        [NMS(Index = 12)]
        /* 0x3AC */ public bool AddPetAccessories;
        [NMS(Index = 3)]
        /* 0x3AD */ public bool FollowWaypoints;
        [NMS(Index = 6)]
        /* 0x3AE */ public bool PlayIdles;
        [NMS(Index = 9)]
        /* 0x3AF */ public bool RidePet;
        [NMS(Index = 8)]
        /* 0x3B0 */ public bool Run;
    }
}
