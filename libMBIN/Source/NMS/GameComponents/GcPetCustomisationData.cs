using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81FAB7230E6A1263, NameHash = 0xEF59F646)]
    public class GcPetCustomisationData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3)]
        /* 0x0 */ public GcCharacterCustomisationSaveData[] Data;
    }
}
