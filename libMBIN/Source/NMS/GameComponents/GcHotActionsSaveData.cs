using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0xCAFFDA6C8A553477, NameHash = 0xE6D4EE849D2F9101)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        // may be the first 0xA elements of GcQuickMenuActions.QuickMenuActionsEnum?
        [NMS(Size = 0xA)]
        public GcQuickMenuActionSaveData[] KeyActions;
    }
}
