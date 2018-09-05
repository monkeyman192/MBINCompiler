namespace libMBIN.Models.Structs
{
    public class GcRichPresenceGlobals : NMSTemplate
    {
        /* 0x0 */ public bool ShowOnScreen;
        /* 0x4 */ public float IdleThreshold;
        /* 0x8 */ public float EvaluationPeriod;
        /* 0xC */ public float PublishPeriod;
        /* 0x10 */ public int PlanetLocationPriority;
        /* 0x14 */ public int SpaceLocationPriority;
        /* 0x18 */ public int StormLocationPriority;
        /* 0x1C */ public int SpaceCombatPriority;
        /* 0x20 */ public int GameModePriority;
    }
}
