using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0xD810FE2932BE120C, NameHash = 0xB9BE8F8A6900C12E)]
    public class GcBaseLinkGridConnectionDependency : NMSTemplate
    {
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        /* 0x38 */ public int DependentRateRate;
        public enum DependentEffectEnum { None, EnablesRate, DisablesRate, EnablesConnection, DisablesConnection }
        /* 0x3C */ public DependentEffectEnum DependentEffect;
        /* 0x40 */ public bool DisableWhenOffline;
        /* 0x41 */ public bool TransfersConnections;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x42 */ public byte[] EndPadding;
    }
}
