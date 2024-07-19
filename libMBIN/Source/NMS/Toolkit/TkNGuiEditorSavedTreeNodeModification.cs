using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD326498633352814, NameHash = 0x5AA13C3E)]
    public class TkNGuiEditorSavedTreeNodeModification : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public List<TkNGuiEditorSavedTreeNodeModification> Children;
        [NMS(Index = 0)]
        /* 0x010 */ public NMSString0x100 Name;
        [NMS(Index = 1)]
        /* 0x110 */ public bool Modified;
    }
}
