using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x50, GUID = 0x18203ECAB461D679, NameHash = 0x7D0C84AE84B756D5)]
    public class TkEntitlementListData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string EntitlementId;
        [NMS(Size = 0x40)]
        public string ServicesID;
    }
}
