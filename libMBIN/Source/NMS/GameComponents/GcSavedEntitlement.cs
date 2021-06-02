using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0xDBC20526A13393C3, NameHash = 0xCEE0D0F77485755F)]
    public class GcSavedEntitlement : NMSTemplate // 0x100 bytes
    {
        public NMSString0x100 EntitlementId;
    }
}