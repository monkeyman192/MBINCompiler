namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC54F39F8901E7E52, NameHash = 0xD1F40E0F6517D194)]
    public class GcRectangularInitialShape : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f BottomLineEnd;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f BottomLineStart;
        [NMS(Index = 1)]
        /* 0x20 */ public Vector3f TopLineEnd;
        [NMS(Index = 0)]
        /* 0x30 */ public Vector3f TopLineStart;
    }
}
