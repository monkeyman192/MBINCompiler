using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD8C84CCD6E74A53B, NameHash = 0xAD17D6D6D824A77D)]
    public class GcWeaponClasses : NMSTemplate
    {
		public enum WeaponClassEnum { Pistol, Rifle, Pristine, Alien }
		public WeaponClassEnum WeaponClass;
    }
}
