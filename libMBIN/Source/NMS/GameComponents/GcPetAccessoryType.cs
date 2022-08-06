using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43FF55FAA5835174, NameHash = 0xB47279F1694E0681)]
    public class GcPetAccessoryType : NMSTemplate
    {
        public enum PetAccessoryEnum {
            None, CargoCylinder, Containers, ShieldArmour, SolarBattery, Tank, WingPanel, TravelPack, SpacePack, CargoLong,
            Antennae, Computer, Toolbelt, LeftCanisters, LeftEnergyCoil, LeftFrigateTurret, LeftHeadLights, LeftArmourPlate, LeftTurret, LeftSupportSystem,
            RightCanisters, RightEnergyCoil, RightFrigateTurret, RightHeadLights, RightArmourPlate, RightTurret, RightSupportSystem
        }
        public PetAccessoryEnum PetAccessory;
    }
}
