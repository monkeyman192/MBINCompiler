using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBEADDD3DA3470429, NameHash = 0x8D835CDF)]
    public class TkNGuiEditorSavedFavourite : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public List<TkNGuiEditorSavedFavourite> Children;
        [NMS(Index = 0)]
        /* 0x010 */ public NMSString0x100 Name;
        [NMS(Index = 1)]
        /* 0x110 */ public bool AddedManually;
    }
}
