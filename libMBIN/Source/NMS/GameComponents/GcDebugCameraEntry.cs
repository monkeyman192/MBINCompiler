namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4711B606E3341A0, NameHash = 0xCF22467E41623053)]
    public class GcDebugCameraEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Local;
        [NMS(Index = 0)]
        /* 0x20 */ public Vector3f Offset;
        [NMS(Index = 3)]
        /* 0x30 */ public Vector3f Up;
        [NMS(Index = 6)]
        /* 0x40 */ public float Distance;
        [NMS(Index = 4)]
        /* 0x44 */ public float FOV;
        [NMS(Index = 5)]
        /* 0x48 */ public float SpeedModifier;
    }
}
