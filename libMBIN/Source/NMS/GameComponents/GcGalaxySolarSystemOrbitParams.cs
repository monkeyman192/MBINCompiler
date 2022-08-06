using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9C076D6012D84D8, NameHash = 0x9A190BDD7FF30DF9)]
    public class GcGalaxySolarSystemOrbitParams : NMSTemplate
    {
        /* 0x00 */ public float FirstOrbitRadiusMin;        // 42480000h
        /* 0x00 */ public float FirstOrbitRadiusMax;        // 42480000h
        /* 0x38 */ public float OrbitRadiusOffsetMin;       // 42480000h
        /* 0x48 */ public float OrbitRadiusOffsetMax;       // 42480000h
        /* 0x4C */ public float OrbitRotationSpeedMin;      // 40A00000h
        /* 0x50 */ public float OrbitRotationSpeedMax;      // 42480000h
        /* 0x54 */ public float OrbitLineWidth;             // 3F800000h
    }
}