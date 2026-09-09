using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24E025806F532195, NameHash = 0x160B1FC2)]
    public class GcMultitoolData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcInWorldUIScreenData ScreenData;
        [NMS(Index = 1)]
        /* 0x030 */ public GcInventoryContainer Store;
        [NMS(Index = 4)]
        /* 0x190 */ public GcCharacterCustomisationData CustomisationData;
        [NMS(Index = 10)]
        /* 0x1E8 */ public GcResourceElement Resource;
        [NMS(Index = 0)]
        /* 0x230 */ public GcInventoryLayout Layout;
        [NMS(Index = 3)]
        /* 0x248 */ public GcSeed Seed;
        [NMS(Index = 7)]
        /* 0x258 */ public int PrimaryMode;
        [NMS(Index = 8)]
        /* 0x25C */ public int SecondaryMode;
        [NMS(Index = 5)]
        /* 0x260 */ public NMSString0x20 Name;
        [NMS(Index = 6)]
        /* 0x280 */ public bool IsLarge;
        [NMS(Index = 9)]
        /* 0x281 */ public bool UseLegacyColours;
    }
}
