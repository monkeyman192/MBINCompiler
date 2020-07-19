using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x1E31FDC16D19BCCB, NameHash = 0x40154165764DAC5)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        public List<GcPlayerDamageData> DamageTable;
    }
}