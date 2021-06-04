using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x380, GUID = 0x2BFC0C7970E3EF42, NameHash = 0x1D427C136EB50E9D)]
    public class GcNPCDebugSpawnData : NMSTemplate
    {
        /* 0x000 */ public Vector3f Position;
        /* 0x010 */ public Vector3f Facing;
        /* 0x020 */ public Vector3f Up;
        /* 0x030 */ public bool FollowWaypoints;
        /* 0x034 */ public float InitialDelay;
        /* 0x038 */ public List<Vector3f> Waypoints;
        /* 0x048 */ public bool PlayIdles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x049 */ public byte[] Padding49;
        /* 0x050 */ public List<NMSString0x10> Idles;
        /* 0x060 */ public bool Run;
        /* 0x061 */ public bool RidePet;
        /* 0x064 */ public GcAlienRace Race;
        /* 0x068 */ public GcSeed Seed;
        /* 0x078 */ public bool AddPetAccessories;
        /* 0x07C */ public float PetFollowOffset;
        /* 0x080 */ public GcPetData Pet;
        /* 0x270 */ public GcPetCustomisationData PetAccessoryCustomisation;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x378 */ public byte[] EndPadding;
    }
}
