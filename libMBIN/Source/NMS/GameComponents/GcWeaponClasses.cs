using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS( Size = 0x4, GUID = 0xD8C84CCD6E74A53B)]
    public class GcWeaponClasses : NMSTemplate
    {
		public enum WeaponClassEnum { Pistol, Rifle, Pristine, Alien }
		public WeaponClassEnum WeaponClass;
    }
}
