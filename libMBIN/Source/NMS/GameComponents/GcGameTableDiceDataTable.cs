using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F9D587BE035827A, NameHash = 0x4BE2CA1D)]
    public class GcGameTableDiceDataTable : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcResourceElement ShakerResource;
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x48 */ public HashMap<GcGameTableDiceConfigData> DiceConfigs;
        [NMS(Index = 1, KeyField = "Id")]
        /* 0x78 */ public HashMap<GcGameTableDiceResourceData> DiceResources;
    }
}
