namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x68106F800288BB7C, NameHash = 0x9B12FDDE20DE4536)]
    public class GcRichPresenceGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float EvaluationPeriod;
        [NMS(Index = 8)]
        /* 0x04 */ public int GameModePriority;
        [NMS(Index = 1)]
        /* 0x08 */ public float IdleThreshold;
        [NMS(Index = 4)]
        /* 0x0C */ public int PlanetLocationPriority;
        [NMS(Index = 3)]
        /* 0x10 */ public float PublishPeriod;
        [NMS(Index = 7)]
        /* 0x14 */ public int SpaceCombatPriority;
        [NMS(Index = 5)]
        /* 0x18 */ public int SpaceLocationPriority;
        [NMS(Index = 6)]
        /* 0x1C */ public int StormLocationPriority;
        [NMS(Index = 0)]
        /* 0x20 */ public bool ShowOnScreen;
    }
}
