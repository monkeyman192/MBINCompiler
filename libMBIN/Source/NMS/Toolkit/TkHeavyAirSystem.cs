namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2BAB61256BF5B670, NameHash = 0x9564BC3EDB74BBA1)]
    public class TkHeavyAirSystem : NMSTemplate
    {
        /* 0x00 */ public Vector3f AmplitudeMax;
        /* 0x10 */ public Vector3f AmplitudeMin;
        /* 0x20 */ public Colour Colour1;
        /* 0x30 */ public Colour Colour2;
        /* 0x40 */ public Vector3f FadeSpeedRange;
        /* 0x50 */ public Vector3f MajorDirection;
        /* 0x60 */ public Vector3f RotationSpeedRange;
        /* 0x70 */ public Vector3f ScaleRange;
        /* 0x80 */ public Vector3f TwinkleRange;
        /* 0x90 */ public float Colour1Alpha;
        /* 0x94 */ public float Colour2Alpha;
        /* 0x98 */ public NMSString0x80 Material;
    }
}
