using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD419BE4F44013B41, NameHash = 0x403FE7D0)]
    public class GcGeneratedBaseTemplatesTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcGeneratedBaseDecorationTemplate> DecorationTemplates;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcGeneratedBasePruningRule> PruningRules;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcGeneratedBaseRoomTemplate> RoomTemplates;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcGeneratedBaseThemeTemplate> ThemeTemplates;
    }
}
