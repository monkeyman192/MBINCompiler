using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6403DD26A54F5F36, NameHash = 0x34EE54AA314E3EDF)]
    public class GcPetEggTraitModifierOverrideTable : NMSTemplate
    {
        public List<GcPetEggTraitModifierOverrideData> TraitModifiers;
    }
}
