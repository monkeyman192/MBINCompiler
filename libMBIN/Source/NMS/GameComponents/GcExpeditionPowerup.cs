using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5391D552DD3258C0, NameHash = 0x5BECBAF4)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A ModuleDescription;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A SelectionDescription;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 ProductId;
        [NMS(Index = 1)]
        /* 0x50 */ public GcFrigateStatType StatModified;
        [NMS(Index = 2)]
        /* 0x54 */ public int ValueChange;
    }
}
