using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE28A64C055994FBA, NameHash = 0x7F0943EC9DBC0BDD)]
    public class GcGeneratedBaseTemplatesTable : NMSTemplate
    {
        /* 0x00 */ public List<GcGeneratedBaseDecorationTemplate> DecorationTemplates;
        /* 0x10 */ public List<GcGeneratedBasePruningRule> PruningRules;
        /* 0x20 */ public List<GcGeneratedBaseRoomTemplate> RoomTemplates;
        /* 0x30 */ public List<GcGeneratedBaseThemeTemplate> ThemeTemplates;
    }
}
