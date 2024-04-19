using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1A0E2DE6B0623BB, NameHash = 0x1D427C136EB50E9D)]
    public class GcNPCDebugSpawnData : NMSTemplate
    {
        /* 0x000 */ public Vector3f Facing;
        /* 0x010 */ public Vector3f Position;
        /* 0x020 */ public Vector3f Up;
        /* 0x030 */ public GcPetData Pet;
        /* 0x238 */ public GcPetCustomisationData PetAccessoryCustomisation;
        /* 0x340 */ public List<NMSString0x10> Idles;
        /* 0x350 */ public GcSeed Seed;
        /* 0x360 */ public List<Vector3f> Waypoints;
        /* 0x370 */ public float InitialDelay;
        /* 0x374 */ public float PetFollowOffset;
        /* 0x378 */ public GcAlienRace Race;
        /* 0x37C */ public bool AddPetAccessories;
        /* 0x37D */ public bool FollowWaypoints;
        /* 0x37E */ public bool PlayIdles;
        /* 0x37F */ public bool RidePet;
        /* 0x380 */ public bool Run;
    }
}
