using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF84D2F6C1E26036, NameHash = 0x13A770D3)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA)]
        /* 0x0 */ public GcQuickMenuActionSaveData[] KeyActions;
    }
}
