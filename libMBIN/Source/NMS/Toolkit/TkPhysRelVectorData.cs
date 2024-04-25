namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFC6B1DE697634A98, NameHash = 0xA03B6D2AF8A02EAB)]
    public class TkPhysRelVectorData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Local;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Offset;
    }
}
