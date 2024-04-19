using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52724DA9E32E1E14, NameHash = 0xB76095BD04FCB5D2)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ModuleDescription;
        /* 0x20 */ public NMSString0x20A SelectionDescription;
        /* 0x40 */ public NMSString0x10 ProductId;
        /* 0x50 */ public GcFrigateStatType StatModified;
        /* 0x54 */ public int ValueChange;
    }
}
