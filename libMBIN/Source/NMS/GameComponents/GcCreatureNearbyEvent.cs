using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x7B4834F9173F66AA, NameHash = 0x42869E79D40A84C1)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        public List<GcCreatureAlertData> AlertTable;
        public bool Inverse;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
