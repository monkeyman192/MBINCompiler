namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43327BC4B129E5A9, NameHash = 0x52B70511)]
    public class GcGalaxySolarSystemOrbitParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float FirstOrbitRadiusMax;
        [NMS(Index = 0)]
        /* 0x04 */ public float FirstOrbitRadiusMin;
        [NMS(Index = 6)]
        /* 0x08 */ public float OrbitLineWidth;
        [NMS(Index = 3)]
        /* 0x0C */ public float OrbitRadiusOffsetMax;
        [NMS(Index = 2)]
        /* 0x10 */ public float OrbitRadiusOffsetMin;
        [NMS(Index = 5)]
        /* 0x14 */ public float OrbitRotationSpeedMax;
        [NMS(Index = 4)]
        /* 0x18 */ public float OrbitRotationSpeedMin;
    }
}
