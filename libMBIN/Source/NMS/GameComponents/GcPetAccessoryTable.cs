using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE4EB06F81A126A1, NameHash = 0x9ED3D0A38623AF53)]
    public class GcPetAccessoryTable : NMSTemplate
    {
        [NMS(Size = 0x1B, EnumType = typeof(GcPetAccessoryType.PetAccessoryEnum))]
        /* 0x000 */ public GcPetAccessoryInfo[] Accessories;
        /* 0x360 */ public List<GcPetAccessoryGroup> AccessoryGroups;

    }
}
