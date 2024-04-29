using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC435E7CBE437663A, NameHash = 0x68651D6CBA2152DE)]
    public class GcNPCColourTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCColourGroup> Groups;
    }
}
