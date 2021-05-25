using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x3DFE945C46B0DBFD, NameHash = 0xA3FCF80E6002BE62)]
    public class GcCreaturePetTraits : NMSTemplate
    {
        // size: 0x3
        public enum PetTraitsEnum { Helpfulness, Aggression, Independence }
        public PetTraitsEnum PetTraits;
    }
}
