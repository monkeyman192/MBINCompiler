namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76172A4A9CF61ADE, NameHash = 0xB7D7488A4EF5FBC3)]
    public class GcTracerData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public float DamageMax;
        [NMS(Index = 3)]
        /* 0x04 */ public float DamageMaxDistance;
        [NMS(Index = 4)]
        /* 0x08 */ public float DamageMin;
        [NMS(Index = 2)]
        /* 0x0C */ public float DamageMinDistance;
        [NMS(Index = 0)]
        /* 0x10 */ public float Length;
        [NMS(Index = 1)]
        /* 0x14 */ public float Speed;
    }
}
