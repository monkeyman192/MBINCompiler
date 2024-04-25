using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2FC43FB23E61302, NameHash = 0x68651D6CBA2152DE)]
    public class GcNPCColourTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCColourGroup> Groups;
    }
}
