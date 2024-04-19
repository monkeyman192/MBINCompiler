namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5C6349F5B7C88586, NameHash = 0x46C380A7C1CCD790)]
    public class TkBoundingBoxData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Max;
        /* 0x10 */ public Vector3f Min;
    }
}
