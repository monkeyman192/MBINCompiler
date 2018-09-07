namespace libMBIN.Models.Structs
{
    public class GcUserSettingsData : NMSTemplate
    {
        // this needs to be fixed!! Has a fair few values missing as can be see in the struct and the file itself

        /* 0x0000 */ public bool InvertLookControls;
        /* 0x0001 */ public bool InvertFlightControls;
        /* 0x0002 */ public bool HUDHidden;
        /* 0x0003 */ public bool Vibration;
        /* 0x0004 */ public int ScreenBrightness;
        /* 0x0008 */ public int MusicVolume;
        /* 0x000C */ public int SfxVolume;
        /* 0x0010 */ public int LookSensitivityV2;
        /* 0x0014 */ public int FlightSensitivityV2;
        /* 0x0018 */ public int MouseSpringSmoothing;
        /* 0x001C */ public GcBlockListPersistence BlockList;
        /* 0x386C */ public int MotionBlurAmount;
        /* 0x3870 */ public int Filter;
        /* 0x3874 */ public bool DamageNumbers;
		public enum BaseSharingModeEnum { Undecided, On, Off }
		public BaseSharingModeEnum BaseSharingMode;
    }
}
