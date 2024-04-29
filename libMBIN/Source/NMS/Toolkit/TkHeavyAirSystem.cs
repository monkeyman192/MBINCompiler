namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x81C4363EF63C416C, NameHash = 0x9564BC3EDB74BBA1)]
    public class TkHeavyAirSystem : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Vector3f AmplitudeMax;
        [NMS(Index = 6)]
        /* 0x10 */ public Vector3f AmplitudeMin;
        [NMS(Index = 8)]
        /* 0x20 */ public Colour Colour1;
        [NMS(Index = 10)]
        /* 0x30 */ public Colour Colour2;
        [NMS(Index = 4)]
        /* 0x40 */ public Vector3f FadeSpeedRange;
        [NMS(Index = 1)]
        /* 0x50 */ public Vector3f MajorDirection;
        [NMS(Index = 3)]
        /* 0x60 */ public Vector3f RotationSpeedRange;
        [NMS(Index = 2)]
        /* 0x70 */ public Vector3f ScaleRange;
        [NMS(Index = 5)]
        /* 0x80 */ public Vector3f TwinkleRange;
        [NMS(Index = 9)]
        /* 0x90 */ public float Colour1Alpha;
        [NMS(Index = 11)]
        /* 0x94 */ public float Colour2Alpha;
        [NMS(Index = 0)]
        /* 0x98 */ public NMSString0x80 Material;
    }
}
