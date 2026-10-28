namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12496AE1A8D58401, NameHash = 0x60F59E61)]
    public class GcWeaponWheelData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public Colour CurrentColour;
        [NMS(Index = 14)]
        /* 0x010 */ public Colour DividerColour;
        [NMS(Index = 15)]
        /* 0x020 */ public Colour DividerOuterColour;
        [NMS(Index = 20)]
        /* 0x030 */ public Colour IconBorderColour;
        [NMS(Index = 12)]
        /* 0x040 */ public Colour InnerBorderColour;
        [NMS(Index = 6)]
        /* 0x050 */ public Colour SegmentInnerColourSelected;
        [NMS(Index = 8)]
        /* 0x060 */ public Colour SegmentInnerColourUnselected;
        [NMS(Index = 7)]
        /* 0x070 */ public Colour SegmentOuterColourSelected;
        [NMS(Index = 9)]
        /* 0x080 */ public Colour SegmentOuterColourUnselected;
        [NMS(Index = 27)]
        /* 0x090 */ public Colour TextBackgroundColour;
        [NMS(Index = 23)]
        /* 0x0A0 */ public Colour TextColour;
        [NMS(Index = 24)]
        /* 0x0B0 */ public Colour TextShadowColour;
        [NMS(Index = 26)]
        /* 0x0C0 */ public Vector2f TextOffset;
        [NMS(Index = 11)]
        /* 0x0C8 */ public float CurrentLineThickness;
        [NMS(Index = 16)]
        /* 0x0CC */ public float DividerThickness;
        [NMS(Index = 2)]
        /* 0x0D0 */ public float FadeTime;
        [NMS(Index = 0)]
        /* 0x0D4 */ public float HoldTime;
        [NMS(Index = 21)]
        /* 0x0D8 */ public float IconBorderThickness;
        [NMS(Index = 19)]
        /* 0x0DC */ public float IconCircleScale;
        [NMS(Index = 17)]
        /* 0x0E0 */ public float IconSize;
        [NMS(Index = 13)]
        /* 0x0E4 */ public float InnerBorderThickness;
        [NMS(Index = 4)]
        /* 0x0E8 */ public float InnerRadius;
        [NMS(Index = 32)]
        /* 0x0EC */ public float MouseDeadZone;
        [NMS(Index = 31)]
        /* 0x0F0 */ public float MouseRadius;
        [NMS(Index = 3)]
        /* 0x0F4 */ public float Radius;
        [NMS(Index = 5)]
        /* 0x0F8 */ public float SegmentOffset;
        [NMS(Index = 30)]
        /* 0x0FC */ public float StickDeadZone;
        [NMS(Index = 29)]
        /* 0x100 */ public float TextBackgroundCornerRadius;
        [NMS(Index = 28)]
        /* 0x104 */ public float TextBackgroundPadding;
        [NMS(Index = 25)]
        /* 0x108 */ public float TextShadowOffset;
        [NMS(Index = 22)]
        /* 0x10C */ public float TextSize;
        [NMS(Index = 33)]
        /* 0x110 */ public float TouchDeadZone;
        [NMS(Index = 1)]
        /* 0x114 */ public float TouchHoldTime;
        [NMS(Index = 18)]
        /* 0x118 */ public float UnselectedIconAlpha;
        [NMS(Index = 35)]
        /* 0x11C */ public float VRWristScale;
        [NMS(Index = 34)]
        /* 0x120 */ public float VRWristScreenFill;
    }
}
