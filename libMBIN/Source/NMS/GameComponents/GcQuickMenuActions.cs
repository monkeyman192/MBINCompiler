using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF7B81A7CB40D60D6, NameHash = 0x5EEC6F79915C67C2)]
    public class GcQuickMenuActions : NMSTemplate
    {
        // 0x2D entries
		public enum QuickMenuActionsEnum { None, CallFreighter, SummonNexus, CallShip, SummonVehicleSubMenu, SummonBuggy, SummonBike, SummonTruck, SummonWheeledBike,
            SummonHovercraft, SummonSubmarine, VehicleScan, VehicleScanSelect, VehicleRestartRace, Torch, GalaxyMap, PhotoMode, ChargeMenu, Charge, ChargeSubMenu,
            Repair, BuildItem, BuildChangeGroup, BuildDelete, BuildColour, BuildMaterial, BuildWireConnection, BuildColourGroup, BuildMaterialGroup, BuildRotateScale,
            CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter, ThirdPersonShip, EconomyScan, EmoteMenu, Emote, UtilitySubMenu, SummonSubMenu, SummonShipSubMenu,
            ChangeSecondaryWeaponMenu, ChangeSecondaryWeapon, ChooseCreatureFoodMenu, ChooseCreatureFood, Invalid }
        public QuickMenuActionsEnum QuickMenuActions;
    }
}
