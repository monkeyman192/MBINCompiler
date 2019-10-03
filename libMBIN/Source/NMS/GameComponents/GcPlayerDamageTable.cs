using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8E78ABF98EBBAF65, NameHash = 0x40154165764DAC5)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        public List<GcPlayerDamageData> DamageTable;
    }
}
