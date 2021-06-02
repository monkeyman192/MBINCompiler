using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x220, GUID = 0x4E77CADABC3706BC, NameHash = 0xB62E6456DFE47836)]
    public class TkGlobals : NMSTemplate
    {
        public enum AssertsLevelEnum { Disabled, Ignored, Skipped, Enabled }
        /* 0x000 */ public AssertsLevelEnum AssertsLevel;
        /* 0x004 */ public bool DefaultSelectIgnoreAsserts;
        [Flags]
        public enum EnabledChannelsEnum
        {
            None = 0x00, Default = 0x01, Note = 0x02, Error = 0x04, Warning = 0x08, Info = 0x10,
            Alt = 0x20, AltWarn = 0x40, AltError = 0x80
        }
        /* 0x008 */ public EnabledChannelsEnum EnabledChannels;
        /* 0x00C */ public NMSString0x100 IncludeLogFilter;
        /* 0x10C */ public NMSString0x100 ExcludeLogFilter;
        /* 0x20C */ public int LoadBalanceTimeoutMS;
        /* 0x210 */ public int VRLoadBalanceTimeoutMS;
        /* 0x214 */ public bool LogInputSetup;
        /* 0x215 */ public bool LogInputChanges;
        /* 0x216 */ public bool DisableResScaling;
        /* 0x218 */ public float WwiseVibrationMultiplierPrimary;
        /* 0x21C */ public float WwiseVibrationMultiplierSecondary;
    }
}
