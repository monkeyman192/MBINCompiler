namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BCCD4CF815D841F, NameHash = 0x44D6DFC8A512D8CB)]
    public class GcAntagonistPerception : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public float Range;
        // size: 0x2
        public enum ViewShapeEnum : uint {
            Pyramid,
            Cone,
        }
        [NMS(Index = 4)]
        /* 0x14 */ public ViewShapeEnum ViewShape;
        [NMS(Index = 2)]
        /* 0x18 */ public float XFOV;
        [NMS(Index = 3)]
        /* 0x1C */ public float YFOV;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x20 SenseLocator;
        [NMS(Index = 5)]
        /* 0x40 */ public bool Raycast;
    }
}
