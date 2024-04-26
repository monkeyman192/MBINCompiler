namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79A76EAFBFCDDB6B, NameHash = 0x2D0ED597896EB5AF)]
    public class GcNGuiActionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 LayerID;
        // size: 0x4
        public enum ActionEnum : uint {
            Click,
            Hover,
            ArrowLeft,
            ArrowRight,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public ActionEnum Action;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x80 Data;
    }
}
