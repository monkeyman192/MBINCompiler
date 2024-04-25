namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEC35274FD7C68F5, NameHash = 0xC148692F6AE43572)]
    public class GcSavedInteractionDialogData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Dialog;
        [NMS(Index = 0)]
        /* 0x20 */ public ulong Hash;
    }
}
