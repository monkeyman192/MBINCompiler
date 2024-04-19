namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE97CCE7C769A7D42, NameHash = 0x9A190BDD7FF30DF9)]
    public class GcGalaxySolarSystemOrbitParams : NMSTemplate
    {
        /* 0x00 */ public float FirstOrbitRadiusMax;
        /* 0x04 */ public float FirstOrbitRadiusMin;
        /* 0x08 */ public float OrbitLineWidth;
        /* 0x0C */ public float OrbitRadiusOffsetMax;
        /* 0x10 */ public float OrbitRadiusOffsetMin;
        /* 0x14 */ public float OrbitRotationSpeedMax;
        /* 0x18 */ public float OrbitRotationSpeedMin;
    }
}
