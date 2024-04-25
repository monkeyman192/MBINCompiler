namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F0CCA79075DBFEF, NameHash = 0xB47279F1694E0681)]
    public class GcPetAccessoryType : NMSTemplate
    {
        // size: 0x1E
        public enum PetAccessoryEnum : uint {
            None,
            CargoCylinder,
            Containers,
            ShieldArmour,
            SolarBattery,
            Tank,
            WingPanel,
            TravelPack,
            SpacePack,
            CargoLong,
            Antennae,
            Computer,
            Toolbelt,
            LeftCanisters,
            LeftEnergyCoil,
            LeftFrigateTurret,
            LeftHeadLights,
            LeftArmourPlate,
            LeftTurret,
            LeftSupportSystem,
            RightCanisters,
            RightEnergyCoil,
            RightFrigateTurret,
            RightHeadLights,
            RightArmourPlate,
            RightTurret,
            RightSupportSystem,
            RightMechanicalPaw,
            LeftMechanicalPaw,
            MechanicalPaw,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetAccessoryEnum PetAccessory;
    }
}
