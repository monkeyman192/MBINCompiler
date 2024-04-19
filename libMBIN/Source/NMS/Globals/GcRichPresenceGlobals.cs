namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x68106F800288BB7C, NameHash = 0x9B12FDDE20DE4536)]
    public class GcRichPresenceGlobals : NMSTemplate
    {
        /* 0x00 */ public float EvaluationPeriod;
        /* 0x04 */ public int GameModePriority;
        /* 0x08 */ public float IdleThreshold;
        /* 0x0C */ public int PlanetLocationPriority;
        /* 0x10 */ public float PublishPeriod;
        /* 0x14 */ public int SpaceCombatPriority;
        /* 0x18 */ public int SpaceLocationPriority;
        /* 0x1C */ public int StormLocationPriority;
        /* 0x20 */ public bool ShowOnScreen;
    }
}
