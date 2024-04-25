using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61AE7C6CD6687A47, NameHash = 0x3DFFD10C388635E7)]
    public class GcCreatureTagAndRarity : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Tag;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCreatureRarity RarityOverride;
    }
}
