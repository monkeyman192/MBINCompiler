namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x531DAA6B2AD23FBE, NameHash = 0x1D538323)]
    public class TkCameraData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f Offset;
        [NMS(Index = 6)]
        /* 0x10 */ public float AdjustPitch;
        [NMS(Index = 7)]
        /* 0x14 */ public float AdjustRoll;
        [NMS(Index = 5)]
        /* 0x18 */ public float AdjustYaw;
        [NMS(Index = 1)]
        /* 0x1C */ public float Angle;
        [NMS(Index = 2)]
        /* 0x20 */ public float Distance;
        [NMS(Index = 0)]
        /* 0x24 */ public float Fov;
        [NMS(Index = 3)]
        /* 0x28 */ public float HeightAngle;
    }
}
