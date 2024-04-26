namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6AF75C9BBA73771, NameHash = 0xA119F734993CBE1E)]
    public class GcInputActionMapping2 : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20 Action;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 ActionSet;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20 Axis;
        [NMS(Index = 2)]
        /* 0x60 */ public NMSString0x20 Button;
    }
}
