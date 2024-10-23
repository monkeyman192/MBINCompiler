using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF342EBC79D21E80D, NameHash = 0xC72226FB)]
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Colour OSDMessageColour;
        [NMS(Index = 14)]
        /* 0x10 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 5)]
        /* 0x30 */ public VariableSizeString OSDMessage;
        [NMS(Index = 6)]
        /* 0x40 */ public VariableSizeString OSDMessageSubtitle;
        [NMS(Index = 12)]
        /* 0x50 */ public NMSString0x10 StatusMessageDefinition;
        [NMS(Index = 13)]
        /* 0x60 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        [NMS(Index = 3)]
        /* 0x70 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 0)]
        /* 0x74 */ public GcMissionCategory Category;
        // size: 0x5
        public enum OSDMessageStyleEnum : uint {
            Standard,
            Fancy,
            Stats,
            Settlement,
            Spook,
        }
        [NMS(Index = 8)]
        /* 0x78 */ public OSDMessageStyleEnum OSDMessageStyle;
        [NMS(Index = 4)]
        /* 0x7C */ public float OSDTime;
        [NMS(Index = 1)]
        /* 0x80 */ public float Time;
        [NMS(Index = 10)]
        /* 0x84 */ public bool DisableIcon;
        [NMS(Index = 11)]
        /* 0x85 */ public bool DisableTitlePrefix;
        [NMS(Index = 9)]
        /* 0x86 */ public bool OSDUseMissionIcon;
    }
}
