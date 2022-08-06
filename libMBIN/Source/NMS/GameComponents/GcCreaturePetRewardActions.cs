using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE275F1D869BA08BC, NameHash = 0xA78B3BB0870D4585)]
    public class GcCreaturePetRewardActions : NMSTemplate
    {
        // size: 0x9
        public enum PetActionEnum { Tickle, Treat, Ride, Customise, Abandon, LayEgg, Adopt, Milk, HarvestSpecial }
        public PetActionEnum PetAction;
    }
}
