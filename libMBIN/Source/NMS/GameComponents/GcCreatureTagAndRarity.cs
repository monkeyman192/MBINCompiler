using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFF2CE7618628D41, NameHash = 0x68F19B20)]
    public class GcCreatureTagAndRarity : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Tag;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCreatureRarity RarityOverride;
    }
}
