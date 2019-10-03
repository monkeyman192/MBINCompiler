using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x62BB5FAB6443D5C5, NameHash = 0xB3E8C8CD4B9DB0B1)]
    public class GcInputActions : NMSTemplate
    {
        // 0x10F entries
        public enum InputActionEnum { Invalid, Player_Forward, Player_Back, Player_Left, Player_Right, Player_SwimUp, Player_SwimDown, Player_Interact, Player_Melee,
            Player_Scan, Player_Torch, Player_Binoculars, Player_Zoom, Player_ShowHUD, Player_Jump, Player_Run, Player_Shoot, Player_Grenade, Player_Reload,
            Player_ChangeWeapon, Player_Deconstruct, Player_ChangeAltWeapon, Player_PlaceMarker, Quick_Menu, Build_Menu, Ship_Thrust, Ship_Brake, Ship_Boost,
            Ship_RollLeft, Ship_RollRight, Ship_Exit, Ship_Land, Ship_Shoot, Ship_ChangeWeapon, Ship_Scan, Ship_PulseJump, Ship_GalacticMap, Ship_TurnLeft, Ship_TurnRight,
            Ship_FreeLook, Vehicle_Forward, Vehicle_Reverse, Vehicle_Left, Vehicle_Right, Vehicle_Brake, Vehicle_Exit, Vehicle_Shoot, Vehicle_ChangeWeapon, Vehicle_Scan,
            Vehicle_Boost, Vehicle_Jump, Vehicle_Horn, Vehicle_AddCheckpoint, Vehicle_DeleteCheckpoint, Fe_Select, Fe_AltSelect, Fe_SelectX, Fe_Back, Fe_Alt1, Fe_Alt1X,
            Fe_Transfer, Fe_Destroy, Gm_Select, Gm_Restart, UI_Left, UI_Right, UI_Left_Sub, UI_Right_Sub, UI_Down_Sub, UI_Up_Sub, UI_NetworkPageShortcut, UI_StackSplitUp,
            UI_StackSplitDown, Fe_ExitMenu, Fe_Options, Fe_Quit, Fe_MsgSkip, Quick_Left, Quick_Right, Quick_Action, Quick_Back, Quick_Up, Quick_Down, Build_Place, Build_Rotate_Left,
            Build_Rotate_Right, Build_AnalogRotateMode1, Build_AnalogRotateMode2, Build_AnalogRotateLeftY, Build_AnalogRotateRightY, Build_AnalogRotateY, Build_AnalogRotateLeftZ,
            Build_AnalogRotateRightZ, Build_AnalogRotateZ, Build_ScaleUp, Build_ScaleDown, Build_AnalogueScale, Build_SelectionMode, Build_Camera, Photo_Hide, Photo_Sun, Photo_Cam,
            Photo_Exit, Photo_CamDown, Photo_CamUp, Photo_Capture, Ambient_Camera, Ambient_Planet, Ambient_System, Ambient_Photo, Ambient_NxtSong, Ambient_Spawn, Terrain_Edit,
            Terrain_ModeBack, Terrain_Menu, Terrain_SizeUp, Terrain_SizeDown, Terrain_RotTerrainLeft, Terrain_RotTerrainRight, Terrain_ChangeShape, Ship_NextTarget,
            Ship_PreviousTarget, Ship_ClosestTarget, CameraLook, CameraLookX, CameraLookY, PlayerMove, PlayerMoveX, PlayerMoveY, SpaceshipThrust, SpaceshipBrake, VehicleMove,
            VehicleSteer, VehicleThrust, VehicleBrake, ShipStrafe, ShipStrafeHorizontal, ShipStrafeVertical, HeldRotate, HeldRotateLeft, HeldRotateRight, ShipSteer, ShipTurn,
            ShipPitch, ShipLook, ShipLookX, ShipLookY, ShipLand, ShipPulse, PlayerSmoothTurnLeft, PlayerSmoothTurnRight, PlayerSnapTurnLeft, PlayerSnapTurnRight, PlayerSnapTurnAround,
            PlayerMoveAround, TeleportDirection, PlayerAutoWalk, InteractLeft, MeleeLeft, HandCtrlHolster, ShipUp, ShipDown, ShipLeft, ShipRight, ShipZoom, Inventory,
            DiscoveryNetworkRetry, QuitGame, ReportBase, GalacticMap_Select, GalacticMap_Deselect, GalacticMap_Exit, GalacticMap_Scan, GalacticMap_Home, GalacticMap_PlanetBase,
            GalacticMap_Accelerate, GalacticMap_ExpandMenu, GalacticMap_ScreenshotToggle, GalacticMap_ScanChooseNext, GalacticMap_ToggleWaypoint, GalacticMap_ClearAllWaypoints,
            GalacticMap_NextNavType, GalacticMap_PreviousNavType, GalacticMap_PreviousFilter, GalacticMap_NextFilter, GalacticMap_CameraLook, GalacticMap_CameraLookX,
            GalacticMap_CameraLookY, GalacticMap_PlayerMove, GalacticMap_PlayerMoveX, GalacticMap_PlayerMoveY, GalacticMap_PlayerMoveForward, GalacticMap_PlayerMoveBackward,
            GalacticMap_PlayerMoveLeft, GalacticMap_PlayerMoveRight, GalacticMap_Up, GalacticMap_Down, GalacticMap_Gesture, UI_Cursor, UI_CursorX, UI_CursorY, UI_Camera,
            UI_CameraX, UI_CameraY, UI_ViewPlayerInfo, UI_NextInputControls, UI_PrevInputControls, UI_ToggleBuySell, UI_ToggleTradeInventory, CharacterCustomisation_ShowCharacter,
            UI_CharacterCustomisation_Camera, UI_CharacterCustomisation_RotateCamera, UI_CharacterCustomisation_PitchCamera, GameMode_CancelDelete, GameMode_TitleStart,
            GameMode_ChangeUser, Binocs_NextMode, Binocs_PrevMode, BaseBuilding_PinRecipe, BaseBuilding_SwitchBase, PhotoMode_CatLeft, PhotoMode_CatRight, PhotoMode_ValueIncrease,
            PhotoMode_ValueDecrease, PhotoMode_OptionUp, PhotoMode_OptionDown, PhotoMode_CameraRollLeft, PhotoMode_CameraRollRight, PhotoMode_PauseApplication, PhotoMode_CopyLocation,
            PhotoMode_HideLocation, HMD_Recenter, HMD_Recenter2, HMD_FEOpen, TextChatOpenClose, TextChatSend, TextChatPasteHold, TextChatPaste, TextChatAutocomplete,
            TextChatAutocompleteModifier, TextChatCursorLeft, TextChatCursorRight, TextChatCursorHome, TextChatCursorEnd, TextChatDelete, Player_InteractSecondary, TogglePause,
            TogglePlanet, Suicide, Reset, AddLastToolbox, AddLastToolboxAtPos, TerrainInvalidate, TogglePipeline, TakeScreenshot, TakeExrScreenshot, ToggleDebugStats,
            ToggleDebugSubpage, DumpNodeStats, ToggleTaa, DebugDropMeasurementAnchor, QuickWarp, DumpStats, DiscoverOwnBase, ClearTerrainEdits, SelectRegion, SwitchRegionRow,
            SwitchRegionAxis, OpenLog, DumpVertStats, Player_TagMarker }
        public InputActionEnum InputAction;
    }
}
