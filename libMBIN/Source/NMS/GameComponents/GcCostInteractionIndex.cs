using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA59A9A433D51E5C, NameHash = 0x8005E8FA6CB39C35)]
    public class GcCostInteractionIndex : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CantAffordLocID;
        /* 0x20 */ public int Index;
        /* 0x24 */ public GcInteractionType InteractionType;
        /* 0x28 */ public GcAlienRace Race;
        /* 0x2C */ public bool AffordIfGreaterThanIndex;
    }
}
