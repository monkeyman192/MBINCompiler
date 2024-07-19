namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB627D162ED638926, NameHash = 0xC73FFBD)]
    public class TkBlackboardValueVector : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Value;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Key;
    }
}
