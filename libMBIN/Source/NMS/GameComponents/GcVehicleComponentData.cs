using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A7707A39AC7BE7, NameHash = 0x38873007)]
    public class GcVehicleComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public TkModelResource WheelModel;
        [NMS(Index = 2)]
        /* 0x18 */ public VariableSizeString Cockpit;
        [NMS(Index = 1)]
        /* 0x28 */ public NMSString0x10 VehicleType;
        [NMS(Index = 8)]
        /* 0x38 */ public int BaseHealth;
        [NMS(Index = 0)]
        /* 0x3C */ public GcVehicleType Class;
        [NMS(Index = 7)]
        /* 0x40 */ public float FoVFixedDistance;
        [NMS(Index = 5)]
        /* 0x44 */ public float MaxHeadPitchDown;
        [NMS(Index = 4)]
        /* 0x48 */ public float MaxHeadPitchUp;
        [NMS(Index = 3)]
        /* 0x4C */ public float MaxHeadTurn;
        [NMS(Index = 6)]
        /* 0x50 */ public float MinTurretAngle;
    }
}
