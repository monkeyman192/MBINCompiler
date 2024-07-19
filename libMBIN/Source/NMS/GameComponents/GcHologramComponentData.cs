using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19E33B36AB6CED67, NameHash = 0x95BA9495)]
    public class GcHologramComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour HologramColour;
        [NMS(Index = 5)]
        /* 0x10 */ public float AttractDistance;
        [NMS(Index = 4)]
        /* 0x14 */ public GcHologramType HologramType;
        [NMS(Index = 9)]
        /* 0x18 */ public float MaxSize;
        [NMS(Index = 8)]
        /* 0x1C */ public float MinSize;
        [NMS(Index = 3)]
        /* 0x20 */ public GcHologramState OnInteractState;
        [NMS(Index = 7)]
        /* 0x24 */ public float RotateTime;
        [NMS(Index = 10)]
        /* 0x28 */ public GcHologramPivotType xPivot;
        [NMS(Index = 11)]
        /* 0x2C */ public GcHologramPivotType yPivot;
        [NMS(Index = 12)]
        /* 0x30 */ public GcHologramPivotType zPivot;
        [NMS(Index = 6)]
        /* 0x34 */ public bool DisableOnInteract;
        [NMS(Index = 2)]
        /* 0x35 */ public bool DisableWhenNotInteracting;
        [NMS(Index = 0)]
        /* 0x36 */ public bool UseStationLightColour;
    }
}
