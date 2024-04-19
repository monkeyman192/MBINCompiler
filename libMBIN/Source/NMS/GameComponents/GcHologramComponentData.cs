using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x936AAB6252C334A9, NameHash = 0xF82082B5132B253)]
    public class GcHologramComponentData : NMSTemplate
    {
        /* 0x00 */ public Colour HologramColour;
        /* 0x10 */ public float AttractDistance;
        /* 0x14 */ public GcHologramType HologramType;
        /* 0x18 */ public float MaxSize;
        /* 0x1C */ public float MinSize;
        /* 0x20 */ public GcHologramState OnInteractState;
        /* 0x24 */ public float RotateTime;
        /* 0x28 */ public GcHologramPivotType xPivot;
        /* 0x2C */ public GcHologramPivotType yPivot;
        /* 0x30 */ public GcHologramPivotType zPivot;
        /* 0x34 */ public bool DisableOnInteract;
        /* 0x35 */ public bool DisableWhenNotInteracting;
        /* 0x36 */ public bool UseStationLightColour;
    }
}
