using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21D5A3379472120A, NameHash = 0x5934F9B0)]
    public class GcAIShipSpawnMarkerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 0)]
        /* 0x20 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 4)]
        /* 0x38 */ public float MaxVisibleRange;
        [NMS(Index = 5)]
        /* 0x3C */ public float MinAngleVisible;
        [NMS(Index = 3)]
        /* 0x40 */ public float MinVisibleRange;
        // size: 0x3
        public enum ShipsToMarkEnum : uint {
            None,
            Leader,
            All,
        }
        [NMS(Index = 6)]
        /* 0x44 */ public ShipsToMarkEnum ShipsToMark;
        [NMS(Index = 2)]
        /* 0x48 */ public bool HideDuringCombat;
    }
}
