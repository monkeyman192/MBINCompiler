namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB44E6EA2FA256B5F, NameHash = 0xF9391B96F83DAF40)]
    public class GcCustomisationBackpackData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f ActiveJetOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 NodeName;
    }
}
