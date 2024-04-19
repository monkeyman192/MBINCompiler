using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x373F7D4782FA500A, NameHash = 0xA3F156D44BBFB2B9)]
    public class GcGalaxyAudioSetupData : NMSTemplate
    {
        /* 0x00 */ public GcAudioWwiseEvents EventAddWaypoint;
        /* 0x04 */ public GcAudioWwiseEvents EventMapEnter;
        /* 0x08 */ public GcAudioWwiseEvents EventMapExit;
        /* 0x0C */ public GcAudioWwiseEvents EventNavmodeChange;
        /* 0x10 */ public GcAudioWwiseEvents EventNavmodeChangeFailed;
        /* 0x14 */ public GcAudioWwiseEvents EventNavmodePathMove;
        /* 0x18 */ public GcAudioWwiseEvents EventPlanetRumble;
        /* 0x1C */ public GcAudioWwiseEvents EventRemoveWaypoint;
        /* 0x20 */ public GcAudioWwiseEvents EventRouteLines;
        /* 0x24 */ public GcAudioWwiseEvents EventSystemDeselect;
        /* 0x28 */ public GcAudioWwiseEvents EventSystemSelect;
        /* 0x2C */ public GcAudioWwiseEvents EventTextAppear;
        /* 0x30 */ public GcAudioWwiseEvents EventWaypointError;
        /* 0x34 */ public GcAudioWwiseEvents EventWaypointLoop;
        /* 0x38 */ public GcAudioWwiseRTPCs RTPCStarWhoosh;
        /* 0x3C */ public float WhooshClip;
        /* 0x40 */ public float WhooshMultiplier;
    }
}
