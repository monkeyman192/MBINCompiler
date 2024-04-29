namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2F9ED93F3BDB4EEE, NameHash = 0x46C380A7C1CCD790)]
    public class TkBoundingBoxData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Max;
        [NMS(Index = 0)]
        /* 0x10 */ public Vector3f Min;
    }
}
