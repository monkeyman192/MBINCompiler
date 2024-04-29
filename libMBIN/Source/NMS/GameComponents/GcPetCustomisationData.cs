using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA70D43434E9E1533, NameHash = 0xBB170982B7A9B162)]
    public class GcPetCustomisationData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3)]
        /* 0x0 */ public GcCharacterCustomisationSaveData[] Data;
    }
}
