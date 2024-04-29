using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x331C686AB877A2FE, NameHash = 0x8847908A288010B2)]
    public class GcVehicleComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 VehicleType;
        [NMS(Index = 9)]
        /* 0x10 */ public TkModelResource WheelModel;
        [NMS(Index = 8)]
        /* 0x94 */ public int BaseHealth;
        [NMS(Index = 0)]
        /* 0x98 */ public GcVehicleType Class;
        [NMS(Index = 7)]
        /* 0x9C */ public float FoVFixedDistance;
        [NMS(Index = 5)]
        /* 0xA0 */ public float MaxHeadPitchDown;
        [NMS(Index = 4)]
        /* 0xA4 */ public float MaxHeadPitchUp;
        [NMS(Index = 3)]
        /* 0xA8 */ public float MaxHeadTurn;
        [NMS(Index = 6)]
        /* 0xAC */ public float MinTurretAngle;
        [NMS(Index = 2)]
        /* 0xB0 */ public NMSString0x80 Cockpit;
    }
}
