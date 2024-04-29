using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE928BC6FFB745EA6, NameHash = 0x7F0943EC9DBC0BDD)]
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
