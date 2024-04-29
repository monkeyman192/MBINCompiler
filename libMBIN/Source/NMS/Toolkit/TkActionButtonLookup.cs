using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1F8B227240979BC0, NameHash = 0x7845DC8347C337B3)]
    public class TkActionButtonLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkActionButtonMap> Lookup;
    }
}
