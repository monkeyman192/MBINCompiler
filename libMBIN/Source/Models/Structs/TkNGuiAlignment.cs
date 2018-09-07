namespace libMBIN.Models.Structs
{
    public class TkNGuiAlignment : NMSTemplate
    {

		public enum VerticalEnum { Top, Middle, Bottom }
		public VerticalEnum Vertical;


		public enum HorizontalEnum { Left, Center, Right }
		public HorizontalEnum Horizontal;
    }
}
