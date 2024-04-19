namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6692F03A70252030, NameHash = 0x5E18E1A975BA4573)]
    public class GcAttachmentPointData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public float AttractionStartDistance;
        /* 0x14 */ public float AttractionStrength;
        /* 0x18 */ public int SimP;
    }
}
