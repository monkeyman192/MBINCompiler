namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6692F03A70252030, NameHash = 0x5E18E1A975BA4573)]
    public class GcAttachmentPointData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 3)]
        /* 0x10 */ public float AttractionStartDistance;
        [NMS(Index = 2)]
        /* 0x14 */ public float AttractionStrength;
        [NMS(Index = 1)]
        /* 0x18 */ public int SimP;
    }
}
