namespace libMBIN.Models.Structs
{
    public class GcNGuiActionData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string LayerID;
        [NMS(Size = 0x80)]
        public string Data;

		public enum ActionEnum { Click, Hover, ArrowLeft, ArrowRight }
		public ActionEnum Action;
    }
}
