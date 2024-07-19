using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94791A075F3CF08B, NameHash = 0x435998E0)]
    public class GcFreighterBaseOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterBaseOption> FreighterBases;
    }
}
