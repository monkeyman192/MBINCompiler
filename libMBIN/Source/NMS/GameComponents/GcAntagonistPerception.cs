namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BCCD4CF815D841F, NameHash = 0x44D6DFC8A512D8CB)]
    public class GcAntagonistPerception : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float Range;
        // size: 0x2
        public enum ViewShapeEnum : uint {
            Pyramid,
            Cone,
        }
        /* 0x14 */ public ViewShapeEnum ViewShape;
        /* 0x18 */ public float XFOV;
        /* 0x1C */ public float YFOV;
        /* 0x20 */ public NMSString0x20 SenseLocator;
        /* 0x40 */ public bool Raycast;
    }
}
