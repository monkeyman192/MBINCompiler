using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88CD3922DC3770EF, NameHash = 0x0A57C34B1B939D649)]
    public class GcCostItemListIndexed : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Costs;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public bool AssertIfOutOfBounds;
        public enum ItemOutOfBoundsBehaviourEnum { NoCost, UseFirst, UseLast }
        /* 0x18 */ public ItemOutOfBoundsBehaviourEnum ItemOutOfBoundsBehaviour;
        public enum ItemIndexProviderEnum { None, Biome, SubBiome }
        /* 0x1C */ public ItemIndexProviderEnum ItemIndexProvider;
    }
}
