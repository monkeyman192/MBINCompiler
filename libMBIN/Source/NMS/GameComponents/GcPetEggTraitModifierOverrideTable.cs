using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0D33396996FBE1C, NameHash = 0x34EE54AA314E3EDF)]
    public class GcPetEggTraitModifierOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetEggTraitModifierOverrideData> TraitModifiers;
    }
}
