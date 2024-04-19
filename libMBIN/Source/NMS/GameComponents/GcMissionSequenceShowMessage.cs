using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6324DDFA4E005F9E, NameHash = 0xECE8B28E154961E9)]
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        /* 0x000 */ public Colour OSDMessageColour;
        /* 0x010 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        /* 0x020 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x024 */ public GcMissionCategory Category;
        // size: 0x4
        public enum OSDMessageStyleEnum : uint {
            Standard,
            Fancy,
            Stats,
            Settlement,
        }
        /* 0x028 */ public OSDMessageStyleEnum OSDMessageStyle;
        /* 0x02C */ public float OSDTime;
        /* 0x030 */ public float Time;
        /* 0x034 */ public NMSString0x80 DebugText;
        /* 0x0B4 */ public NMSString0x80 Message;
        /* 0x134 */ public NMSString0x80 OSDMessage;
        /* 0x1B4 */ public NMSString0x80 OSDMessageSubtitle;
        /* 0x234 */ public bool DisableIcon;
        /* 0x235 */ public bool DisableTitlePrefix;
        /* 0x236 */ public bool OSDUseMissionIcon;
    }
}
