using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15D3F987A25D7FCE, NameHash = 0x8847908A288010B2)]
    public class GcVehicleComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 VehicleType;
        /* 0x10 */ public TkModelResource WheelModel;
        /* 0x94 */ public int BaseHealth;
        /* 0x98 */ public GcVehicleType Class;
        /* 0x9C */ public float FoVFixedDistance;
        /* 0xA0 */ public float MaxHeadPitchDown;
        /* 0xA4 */ public float MaxHeadPitchUp;
        /* 0xA8 */ public float MaxHeadTurn;
        /* 0xAC */ public float MinTurretAngle;
        /* 0xB0 */ public NMSString0x80 Cockpit;
    }
}
