using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70C0BFF81F88B5F, NameHash = 0xC72226FB)]
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Colour OSDMessageColour;
        [NMS(Index = 13)]
        /* 0x10 */ public NMSString0x10 CameraShakeID;
        [NMS(Index = 18)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 5)]
        /* 0x40 */ public VariableSizeString OSDMessage;
        [NMS(Index = 6)]
        /* 0x50 */ public VariableSizeString OSDMessageSubtitle;
        [NMS(Index = 12)]
        /* 0x60 */ public NMSString0x10 StatusMessageDefinition;
        [NMS(Index = 17)]
        /* 0x70 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        [NMS(Index = 3)]
        /* 0x80 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 0)]
        /* 0x84 */ public GcMissionCategory Category;
        [NMS(Index = 16)]
        /* 0x88 */ public float EffectTime;
        // size: 0x5
        public enum OSDMessageStyleEnum : uint {
            Standard,
            Fancy,
            Stats,
            Settlement,
            Spook,
        }
        [NMS(Index = 8)]
        /* 0x8C */ public OSDMessageStyleEnum OSDMessageStyle;
        [NMS(Index = 4)]
        /* 0x90 */ public float OSDTime;
        [NMS(Index = 1)]
        /* 0x94 */ public float Time;
        [NMS(Index = 10)]
        /* 0x98 */ public bool DisableIcon;
        [NMS(Index = 11)]
        /* 0x99 */ public bool DisableTitlePrefix;
        [NMS(Index = 14)]
        /* 0x9A */ public bool DoCameraShake;
        [NMS(Index = 15)]
        /* 0x9B */ public bool DoWhiteout;
        [NMS(Index = 9)]
        /* 0x9C */ public bool OSDUseMissionIcon;
    }
}
