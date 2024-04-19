namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD2BC029069D4E1F, NameHash = 0x84279994558A47D)]
    public class GcInteractionData : NMSTemplate
    {
        /* 0x00 */ public Vector4f Position;
        /* 0x10 */ public ulong GalacticAddress;
        /* 0x18 */ public ulong Value;
    }
}
