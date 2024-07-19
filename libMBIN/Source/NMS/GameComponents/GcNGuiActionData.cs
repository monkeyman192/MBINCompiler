namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA288AF0F4C6E31B, NameHash = 0x199845)]
    public class GcNGuiActionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString Data;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 LayerID;
        // size: 0x4
        public enum ActionEnum : uint {
            Click,
            Hover,
            ArrowLeft,
            ArrowRight,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public ActionEnum Action;
    }
}
