using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x934A2D8C9FFC7B12, NameHash = 0xECE8B28E154961E9)]
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        /* 0x000 */ public GcMissionCategory Category;
        /* 0x004 */ public float Time;
        /* 0x008 */ public NMSString0x80 Message;
        /* 0x088 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x08C */ public float OSDTime;
        /* 0x090 */ public NMSString0x80 OSDMessage;
        /* 0x110 */ public NMSString0x80 OSDMessageSubtitle;
        /* 0x190 */ public Colour OSDMessageColour;
        // size: 0x4
        public enum OSDMessageStyleEnum { Standard, Fancy, Stats, Settlement }
        /* 0x1A0 */ public OSDMessageStyleEnum OSDMessageStyle;
        /* 0x1A4 */ public bool OSDUseMissionIcon;
        /* 0x1A5 */ public bool DisableIcon;
        /* 0x1A6 */ public bool DisableTitlePrefix;
        /* 0x1A7 */ public NMSString0x80 DebugText;
    }
}
