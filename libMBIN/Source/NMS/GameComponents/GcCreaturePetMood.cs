using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x1AC7B635602FC45A, NameHash = 0x02581D5C5DE2A6E6)]
    public class GcCreaturePetMood : NMSTemplate
    {
        // size: 0x2
        public enum PetMoodEnum { Hungry, Lonely }
        public PetMoodEnum PetMood;
    }
}
