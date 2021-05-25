using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x3FA159601A988735, NameHash = 0x798B3001AC5A7114)]
    public class GcMissionConditionWeaponMode : NMSTemplate
    {
        public GcPlayerWeapons WeaponMode;
    }
}