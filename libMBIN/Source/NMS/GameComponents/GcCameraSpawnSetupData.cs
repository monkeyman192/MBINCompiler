namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77E5B27EBCBE2547, NameHash = 0x9F0F26C55027F010)]
    public class GcCameraSpawnSetupData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Distance;
        [NMS(Index = 3)]
        /* 0x4 */ public float HorizontalProportion;
        [NMS(Index = 2)]
        /* 0x8 */ public float YawProportion;
        [NMS(Index = 1)]
        /* 0xC */ public bool InFrontOfShip;
    }
}
