using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79511EBB713E4B71, NameHash = 0xC5B9CCD1978B8755)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcCharacterCustomisationData CustomData;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 SelectedPreset;
    }
}
