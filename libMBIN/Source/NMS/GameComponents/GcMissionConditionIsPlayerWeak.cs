using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E18159DA19C16C, NameHash = 0x1B69E5D9C1463621)]
    public class GcMissionConditionIsPlayerWeak : NMSTemplate
    {
        public enum ProgressTypeEnum { ShipOrWeapon, Ship, Weapon }
        public ProgressTypeEnum ProgressType;
    }
}
