namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8E9D85406F8942E4, NameHash = 0xE02A1CA9048E3A96)]
    public class TkInstanceWindComponentData : NMSTemplate
    {
        /* 0x00 */ public float BaseMass;
        /* 0x04 */ public float BaseSpring;
        /* 0x08 */ public float LinearDamping;
        /* 0x0C */ public float MassReduction;
        /* 0x10 */ public float SpringLengthFactor;
        /* 0x14 */ public float SpringNonDirFactor;
        /* 0x18 */ public float SpringReduction;
        /* 0x1C */ public bool EnableLdsWind;
    }
}
