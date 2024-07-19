using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA71B2315EF8F8E77, NameHash = 0x13A770D3)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA)]
        /* 0x0 */ public GcQuickMenuActionSaveData[] KeyActions;
    }
}
