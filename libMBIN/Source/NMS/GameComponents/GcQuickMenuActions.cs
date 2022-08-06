using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EB3E7F2C08A6927, NameHash = 0x5EEC6F79915C67C2)]
    public class GcQuickMenuActions : NMSTemplate
    {
        // size: 0x39
        public enum QuickMenuActionsEnum { None, CallFreighter, DismissFreighter, SummonNexus, CallShip, CallSquadron,
            SummonVehicleSubMenu, SummonBuggy, SummonBike, SummonTruck, SummonWheeledBike,
            SummonHovercraft, SummonSubmarine, SummonMech, VehicleAIToggle,
            VehicleScan, VehicleScanSelect, VehicleRestartRace, Torch, GalaxyMap,
            PhotoMode, ChargeMenu, Charge, ChargeSubMenu, Repair, BuildMenu,
            CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter, ThirdPersonShip,
            ThirdPersonVehicle, EconomyScan, EmoteMenu, Emote, UtilitySubMenu,
            SummonSubMenu, SummonShipSubMenu, ChangeSecondaryWeaponMenu,
            ChangeSecondaryWeapon, ChooseCreatureFoodMenu, ChooseCreatureFood, EmergencyWarp,
            SwapMultitool, SwapMultitoolSubMenu, CreatureSubMenu, SummonPet,
            SummonPetSubMenu, WarpToNexus, PetUI, ByteBeatSubMenu, ByteBeatPlay,
            ByteBeatStop, ByteBeatLibrary, ReportBase, CargoShield, CallRocket,
            Invalid
        }
        /* 0x0 */ public QuickMenuActionsEnum QuickMenuActions;
    }
}
