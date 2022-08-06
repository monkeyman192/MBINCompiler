using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A58180977771FE2, NameHash = 0xFC3C64D0A5373C54)]
    public class GcCreaturePetTraitRange : NMSTemplate
    {
        public float Min;
        public float Max;
    }
}
