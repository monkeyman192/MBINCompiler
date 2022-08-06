using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDBA6938E9D54B281, NameHash = 0x7F0943EC9DBC0BDD)]
    public class GcGeneratedBaseTemplatesTable : NMSTemplate
    {
        /* 0x00 */ public List<GcGeneratedBaseDecorationTemplate> DecorationTemplates;
        /* 0x10 */ public List<GcGeneratedBaseRoomTemplate> RoomTemplates;
        /* 0x20 */ public List<GcGeneratedBaseThemeTemplate> ThemeTemplates;
        /* 0x30 */ public List<GcGeneratedBasePruningRule> PruningRules;
    }
}
