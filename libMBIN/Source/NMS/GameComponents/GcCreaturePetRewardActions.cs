using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x12F0CFFEB3957D33, NameHash = 0xA78B3BB0870D4585)]
    public class GcCreaturePetRewardActions : NMSTemplate
    {
        // size: 0x8
        public enum PetActionEnum { Tickle, Treat, Ride, Customise, Abandon, LayEgg, Adopt, Milk }
        public PetActionEnum PetAction;
    }
}
