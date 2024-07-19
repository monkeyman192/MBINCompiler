using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA9DDBFEAFCE4D549, NameHash = 0x89A9DF9A)]
    public class TkActionButtonLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkActionButtonMap> Lookup;
    }
}
