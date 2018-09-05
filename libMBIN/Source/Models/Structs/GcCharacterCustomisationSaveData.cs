namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x58)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
