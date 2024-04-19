using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x103B4E1E1547DE0E, NameHash = 0xDB40771B3EB38336)]
    public class GcAIShipSpawnMarkerData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A MarkerLabel;
        /* 0x20 */ public TkTextureResource MarkerIcon;
        /* 0xA4 */ public float MaxVisibleRange;
        /* 0xA8 */ public float MinAngleVisible;
        /* 0xAC */ public float MinVisibleRange;
        // size: 0x3
        public enum ShipsToMarkEnum : uint {
            None,
            Leader,
            All,
        }
        /* 0xB0 */ public ShipsToMarkEnum ShipsToMark;
        /* 0xB4 */ public bool HideDuringCombat;
    }
}
