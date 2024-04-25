using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC63BC1A73009517, NameHash = 0x9ED3D0A38623AF53)]
    public class GcPetAccessoryTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1E, EnumType = typeof(GcPetAccessoryType.PetAccessoryEnum))]
        /* 0x000 */ public GcPetAccessoryInfo[] Accessories;
        [NMS(Index = 1)]
        /* 0x3C0 */ public List<GcPetAccessoryGroup> AccessoryGroups;
    }
}
