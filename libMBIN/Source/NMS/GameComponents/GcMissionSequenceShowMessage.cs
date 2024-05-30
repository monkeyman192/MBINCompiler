using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8DB87C08C2D2D75, NameHash = 0xECE8B28E154961E9)]
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public Colour OSDMessageColour;
        [NMS(Index = 12)]
        /* 0x010 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        [NMS(Index = 3)]
        /* 0x020 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 0)]
        /* 0x024 */ public GcMissionCategory Category;
        // size: 0x4
        public enum OSDMessageStyleEnum : uint {
            Standard,
            Fancy,
            Stats,
            Settlement,
        }
        [NMS(Index = 8)]
        /* 0x028 */ public OSDMessageStyleEnum OSDMessageStyle;
        [NMS(Index = 4)]
        /* 0x02C */ public float OSDTime;
        [NMS(Index = 1)]
        /* 0x030 */ public float Time;
        [NMS(Index = 13)]
        /* 0x034 */ public NMSString0x80 DebugText;
        [NMS(Index = 2)]
        /* 0x0B4 */ public NMSString0x80 Message;
        [NMS(Index = 5)]
        /* 0x134 */ public NMSString0x80 OSDMessage;
        [NMS(Index = 6)]
        /* 0x1B4 */ public NMSString0x80 OSDMessageSubtitle;
        [NMS(Index = 10)]
        /* 0x234 */ public bool DisableIcon;
        [NMS(Index = 11)]
        /* 0x235 */ public bool DisableTitlePrefix;
        [NMS(Index = 9)]
        /* 0x236 */ public bool OSDUseMissionIcon;
    }
}
