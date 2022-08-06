using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7ED9817F76276B01, NameHash = 0xB113E9A825921723)]
    public class GcCreatureSizeClasses : NMSTemplate
    {
		public enum CreatureSizeClassEnum { Small, Medium, Large, Huge }
		public CreatureSizeClassEnum CreatureSizeClass;
    }
}