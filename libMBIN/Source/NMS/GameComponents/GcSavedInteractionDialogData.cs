using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xA80997A95CD03CAA, NameHash = 0xC148692F6AE43572)]
    public class GcSavedInteractionDialogData : NMSTemplate
    {
        public ulong Hash;
        public NMSString0x20 Dialog;
    }
}
