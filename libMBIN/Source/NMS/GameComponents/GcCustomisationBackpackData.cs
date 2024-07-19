namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D5E51F8B89FD5D1, NameHash = 0xEA80BCC2)]
    public class GcCustomisationBackpackData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f ActiveJetOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 NodeName;
    }
}
