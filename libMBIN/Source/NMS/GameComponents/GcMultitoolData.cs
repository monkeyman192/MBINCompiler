using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x760E5C6933844DCA, NameHash = 0x160B1FC2)]
    public class GcMultitoolData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcInWorldUIScreenData ScreenData;
        [NMS(Index = 1)]
        /* 0x030 */ public GcInventoryContainer Store;
        [NMS(Index = 4)]
        /* 0x188 */ public GcCharacterCustomisationData CustomisationData;
        [NMS(Index = 10)]
        /* 0x1E0 */ public GcResourceElement Resource;
        [NMS(Index = 0)]
        /* 0x228 */ public GcInventoryLayout Layout;
        [NMS(Index = 3)]
        /* 0x240 */ public GcSeed Seed;
        [NMS(Index = 7)]
        /* 0x250 */ public int PrimaryMode;
        [NMS(Index = 8)]
        /* 0x254 */ public int SecondaryMode;
        [NMS(Index = 5)]
        /* 0x258 */ public NMSString0x20 Name;
        [NMS(Index = 6)]
        /* 0x278 */ public bool IsLarge;
        [NMS(Index = 9)]
        /* 0x279 */ public bool UseLegacyColours;
    }
}
