using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26B598C2ECD1F4F0, NameHash = 0x6F0E264357FD693D)]
    public class GcDeprecatedAssetsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x80> Table;
    }
}
