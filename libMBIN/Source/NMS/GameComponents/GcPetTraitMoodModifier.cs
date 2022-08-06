using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E56BFDB45085DB4, NameHash = 0xEC05D45E23EDDB7A)]
    public class GcPetTraitMoodModifier : NMSTemplate
    {
        /* 0x0 */ public float TraitMin;
        /* 0x4 */ public float TraitMax;
        /* 0x8 */ public float MoodIncreaseMultiplierMin;
        /* 0xC */ public float MoodIncreaseMultiplierMax;
    }
}
