namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyAudioSetupData : NMSTemplate
    {
        public GcAudioWwiseEvents EventMapEnter;
        public GcAudioWwiseEvents EventMapExit;
        public GcAudioWwiseEvents EventSystemSelect;
        public GcAudioWwiseEvents EventSystemDeselect;
        public GcAudioWwiseEvents EventTextAppear;
        public GcAudioWwiseEvents EventRouteLines;
        public GcAudioWwiseEvents EventAddWaypoint;
        public GcAudioWwiseEvents EventRemoveWaypoint;
        public GcAudioWwiseEvents EventWaypointError;
        public GcAudioWwiseEvents EventWaypointLoop;
        public GcAudioWwiseEvents EventNavmodeChange;
        public GcAudioWwiseEvents EventNavmodeChangeFailed;
        public GcAudioWwiseEvents EventNavmodePathMove;
        public GcAudioWwiseEvents EventPlanetRumble;
        public GcAudioWwiseRTPCs RTPCStarWhoosh;
        public float WhooshClip;
        public float WhooshMultiplier;
    }
}
