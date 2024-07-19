namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1661BB70F9B8D578, NameHash = 0xD5D20C1)]
    public class TkInstanceWindComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float BaseMass;
        [NMS(Index = 3)]
        /* 0x04 */ public float BaseSpring;
        [NMS(Index = 5)]
        /* 0x08 */ public float LinearDamping;
        [NMS(Index = 2)]
        /* 0x0C */ public float MassReduction;
        [NMS(Index = 7)]
        /* 0x10 */ public float SpringLengthFactor;
        [NMS(Index = 6)]
        /* 0x14 */ public float SpringNonDirFactor;
        [NMS(Index = 4)]
        /* 0x18 */ public float SpringReduction;
        [NMS(Index = 0)]
        /* 0x1C */ public bool EnableLdsWind;
    }
}
