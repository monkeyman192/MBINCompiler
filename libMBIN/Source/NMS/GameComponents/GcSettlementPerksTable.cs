using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB82581FCA088C3E5, NameHash = 0x3FBCD98A534164CD)]
    public class GcSettlementPerksTable : NMSTemplate
    {
        public List<GcSettlementPerkData> Table;
    }
}
