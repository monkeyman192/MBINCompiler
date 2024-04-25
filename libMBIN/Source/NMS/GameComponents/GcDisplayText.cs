using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D689169E0D2D935, NameHash = 0x39E3C3DE16466069)]
    public class GcDisplayText : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public List<NMSString0x20A> ChooseRandomTextOptions;
        // size: 0x5
        public enum HUDTextDisplayTypeEnum : uint {
            Full,
            Compact,
            EyeLevel,
            Prompt,
            Tooltip,
        }
        [NMS(Index = 0)]
        /* 0x010 */ public HUDTextDisplayTypeEnum HUDTextDisplayType;
        [NMS(Index = 4)]
        /* 0x014 */ public GcAlienRace UseAlienLanguage;
        [NMS(Index = 2)]
        /* 0x018 */ public NMSString0x100 Subtitle1;
        [NMS(Index = 3)]
        /* 0x118 */ public NMSString0x100 Subtitle2;
        [NMS(Index = 1)]
        /* 0x218 */ public NMSString0x100 Title;
    }
}
