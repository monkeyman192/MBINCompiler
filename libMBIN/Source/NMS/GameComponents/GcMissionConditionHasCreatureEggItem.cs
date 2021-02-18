using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x921B1E869D0F6343, NameHash = 0x6FDB38E1B65AEDCB)]
    public class GcMissionConditionHasCreatureEggItem : NMSTemplate
    {
        public enum EggItemTypeEnum { Egg, ValidCatalyst }
        /* 0x0 */ public EggItemTypeEnum EggItemType;
        /* 0x4 */ public bool IncludeEggMachineInventoryInSearch;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] EndPadding;
    }
}
