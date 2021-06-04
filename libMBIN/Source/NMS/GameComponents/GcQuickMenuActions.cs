using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xE15B6DFE7BEFC834, NameHash = 0x5EEC6F79915C67C2)]
    public class GcQuickMenuActions : NMSTemplate
    {
        // size: 0x3B
		public enum QuickMenuActionsEnum {
            None, CallFreighter, SummonNexus, CallShip, SummonVehicleSubMenu, SummonBuggy, SummonBike, SummonTruck, SummonWheeledBike, SummonHovercraft,
            SummonSubmarine, SummonMech, VehicleScan, VehicleScanSelect, VehicleRestartRace, Torch, GalaxyMap, PhotoMode, ChargeMenu, Charge,
            ChargeSubMenu, Repair, BuildItem, BuildChangeGroup, BuildDelete, BuildColour, BuildMaterial, BuildWireConnection, BuildColourGroup, BuildMaterialGroup,
            BuildReportBase, BuildRotateScale, CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter, ThirdPersonShip, ThirdPersonVehicle, EconomyScan, EmoteMenu, Emote,
            UtilitySubMenu, SummonSubMenu, SummonShipSubMenu, ChangeSecondaryWeaponMenu, ChangeSecondaryWeapon, ChooseCreatureFoodMenu, ChooseCreatureFood, EmergencyWarp, SwapMultitool, SwapMultitoolSubMenu,
            CreatureSubMenu, SummonPet, WarpToNexus, PetUI, ByteBeatSubMenu, ByteBeatPlay, ByteBeatStop, ByteBeatLibrary, Invalid
        }
        public QuickMenuActionsEnum QuickMenuActions;
    }
}
