namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A9D4116B2E777CD, NameHash = 0x96BA7F736F446E96)]
    public class GcMissionSequenceSummonNexus : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x100 */ public bool IgnorePlanetRadiusAndForceSpawn;
    }
}
