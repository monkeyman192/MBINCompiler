using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51CEC494265F44F6, NameHash = 0xB5E5441084DA383E)]
    public class GcFreighterBaseOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterBaseOption> FreighterBases;
    }
}
