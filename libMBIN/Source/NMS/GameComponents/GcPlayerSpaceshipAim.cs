namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x675EC987772032F1, NameHash = 0xD03BA349FC9AC748)]
    public class GcPlayerSpaceshipAim : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float AimAngleMin;
        [NMS(Index = 1)]
        /* 0x04 */ public float AimAngleRange;
        [NMS(Index = 2)]
        /* 0x08 */ public float AimDistanceAngleMin;
        [NMS(Index = 3)]
        /* 0x0C */ public float AimDistanceAngleRange;
        [NMS(Index = 4)]
        /* 0x10 */ public float AimDistanceMin;
        [NMS(Index = 5)]
        /* 0x14 */ public float AimDistanceRange;
    }
}
