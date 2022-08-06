using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7DCD88B585C7E632, NameHash = 0x8847908A288010B2)]
    public class GcVehicleComponentData : NMSTemplate
    {
        /* 0x00 */ public GcVehicleType Class;
        /* 0x08 */ public NMSString0x10 VehicleType;
        /* 0x18 */ public NMSString0x80 Cockpit;
        /* 0x98 */ public float MaxHeadTurn;
        /* 0x9C */ public float MaxHeadPitchUp;
        /* 0xA0 */ public float MaxHeadPitchDown;
        /* 0xA4 */ public float MinTurretAngle;
        /* 0xA8 */ public float FoVFixedDistance;
        /* 0xAC */ public int BaseHealth;
        /* 0xB0 */ public TkModelResource WheelModel;
    }
}
