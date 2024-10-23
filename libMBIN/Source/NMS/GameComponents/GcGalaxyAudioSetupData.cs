using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E2BF046986614F6, NameHash = 0xBEC6F214)]
    public class GcGalaxyAudioSetupData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public GcAudioWwiseEvents EventAddWaypoint;
        [NMS(Index = 0)]
        /* 0x04 */ public GcAudioWwiseEvents EventMapEnter;
        [NMS(Index = 1)]
        /* 0x08 */ public GcAudioWwiseEvents EventMapExit;
        [NMS(Index = 10)]
        /* 0x0C */ public GcAudioWwiseEvents EventNavmodeChange;
        [NMS(Index = 11)]
        /* 0x10 */ public GcAudioWwiseEvents EventNavmodeChangeFailed;
        [NMS(Index = 12)]
        /* 0x14 */ public GcAudioWwiseEvents EventNavmodePathMove;
        [NMS(Index = 13)]
        /* 0x18 */ public GcAudioWwiseEvents EventPlanetRumble;
        [NMS(Index = 7)]
        /* 0x1C */ public GcAudioWwiseEvents EventRemoveWaypoint;
        [NMS(Index = 5)]
        /* 0x20 */ public GcAudioWwiseEvents EventRouteLines;
        [NMS(Index = 3)]
        /* 0x24 */ public GcAudioWwiseEvents EventSystemDeselect;
        [NMS(Index = 2)]
        /* 0x28 */ public GcAudioWwiseEvents EventSystemSelect;
        [NMS(Index = 4)]
        /* 0x2C */ public GcAudioWwiseEvents EventTextAppear;
        [NMS(Index = 8)]
        /* 0x30 */ public GcAudioWwiseEvents EventWaypointError;
        [NMS(Index = 9)]
        /* 0x34 */ public GcAudioWwiseEvents EventWaypointLoop;
        [NMS(Index = 14)]
        /* 0x38 */ public GcAudioWwiseRTPCs RTPCStarWhoosh;
        [NMS(Index = 15)]
        /* 0x3C */ public float WhooshClip;
        [NMS(Index = 16)]
        /* 0x40 */ public float WhooshMultiplier;
    }
}
