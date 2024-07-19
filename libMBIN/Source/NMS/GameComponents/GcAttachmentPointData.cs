namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57878A41DE9669CC, NameHash = 0x7ECCAEA3)]
    public class GcAttachmentPointData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public int SimP;
    }
}
