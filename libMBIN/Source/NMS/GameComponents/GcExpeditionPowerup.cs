using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52724DA9E32E1E14, NameHash = 0xB76095BD04FCB5D2)]
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
