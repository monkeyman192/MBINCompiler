using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9E71BE836C390C18, NameHash = 0x5BFC087E90D1520B)]
    public class TkNoiseFlattenFixedPosition : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public TkNoiseFlattenPoint FlattenPoint;
    }
}
