namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA9F3D46578C7B0, NameHash = 0xB7D7488A4EF5FBC3)]
    public class GcTracerData : NMSTemplate
    {
        /* 0x00 */ public float DamageMax;
        /* 0x04 */ public float DamageMaxDistance;
        /* 0x08 */ public float DamageMin;
        /* 0x0C */ public float DamageMinDistance;
        /* 0x10 */ public float Length;
        /* 0x14 */ public float Speed;
    }
}
