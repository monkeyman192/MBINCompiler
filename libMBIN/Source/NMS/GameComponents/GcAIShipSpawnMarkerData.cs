using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x103B4E1E1547DE0E, NameHash = 0xDB40771B3EB38336)]
    public class GcAIShipSpawnMarkerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 0)]
        /* 0x20 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 4)]
        /* 0xA4 */ public float MaxVisibleRange;
        [NMS(Index = 5)]
        /* 0xA8 */ public float MinAngleVisible;
        [NMS(Index = 3)]
        /* 0xAC */ public float MinVisibleRange;
        // size: 0x3
        public enum ShipsToMarkEnum : uint {
            None,
            Leader,
            All,
        }
        [NMS(Index = 6)]
        /* 0xB0 */ public ShipsToMarkEnum ShipsToMark;
        [NMS(Index = 2)]
        /* 0xB4 */ public bool HideDuringCombat;
    }
}
