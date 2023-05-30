using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x00 */ public bool InvertLookControls;
        /* 0x01 */ public bool InvertFlightControls;
        /* 0x02 */ public bool Vibration;

        /* 0x04 */ public int ScreenBrightness;
        /* 0x08 */ public int MusicVolume;
        /* 0x0C */ public int SfxVolume;
        /* 0x10 */ public int LookSensitivity;
        /* 0x14 */ public int FlightSensitivity;
    }
}
