namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4913DD4F5BD20BEF, NameHash = 0x1805828080FC646E)]
    public class GcWorldUISettings : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public float GameModeSelectorQuadOffset;
        [NMS(Index = 19)]
        /* 0x04 */ public float GameModeSelectorQuadOffsetV2;
        [NMS(Index = 9)]
        /* 0x08 */ public float HUDDefWorldQuadOffset;
        [NMS(Index = 10)]
        /* 0x0C */ public float HUDDefWorldQuadOffsetV2;
        [NMS(Index = 11)]
        /* 0x10 */ public float HUDDefWorldQuadShipAddOffset;
        [NMS(Index = 12)]
        /* 0x14 */ public float HUDDefWorldQuadShipAddOffsetV2;
        [NMS(Index = 15)]
        /* 0x18 */ public float HUDInterpSpeed;
        [NMS(Index = 17)]
        /* 0x1C */ public float HUDThresholdHorz;
        [NMS(Index = 16)]
        /* 0x20 */ public float HUDThresholdVert;
        [NMS(Index = 13)]
        /* 0x24 */ public float HUDWorldQuadScale;
        [NMS(Index = 14)]
        /* 0x28 */ public float HUDWorldQuadShipScale;
        [NMS(Index = 0)]
        /* 0x2C */ public float UIWorldQuadOffset;
        [NMS(Index = 2)]
        /* 0x30 */ public float UIWorldQuadOffsetBuildMenu;
        [NMS(Index = 3)]
        /* 0x34 */ public float UIWorldQuadOffsetBuildMenuV2;
        [NMS(Index = 1)]
        /* 0x38 */ public float UIWorldQuadOffsetV2;
        [NMS(Index = 7)]
        /* 0x3C */ public float UIWorldQuadScale;
        [NMS(Index = 5)]
        /* 0x40 */ public float UIWorldQuadShipAddOffset;
        [NMS(Index = 6)]
        /* 0x44 */ public float UIWorldQuadShipAddOffsetV2;
        [NMS(Index = 8)]
        /* 0x48 */ public float UIWorldQuadShipScale;
        [NMS(Index = 4)]
        /* 0x4C */ public float UIWorldQuadSideOffset;
    }
}
