using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D2D002F54571188, NameHash = 0x6EA814E2)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcCharacterCustomisationData CustomData;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 SelectedPreset;
    }
}
