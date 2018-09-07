namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x304)]
    public class GcDisplayText : NMSTemplate
    {
		public enum HUDTextDisplayTypeEnum { Full, Compact, EyeLevel, Prompt, Tooltip }
		public HUDTextDisplayTypeEnum HUDTextDisplayType;

        [NMS(Size = 0x100)]
        public string Title;
        [NMS(Size = 0x100)]
        public string Subtitle1;
        [NMS(Size = 0x100)]
        public string Subtitle2;
    }
}
