namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AF3BDFA5A395D83, NameHash = 0xFDF8A4BB)]
    public class GcMissionConditionSystemHasCorruptedPlanet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool AllowNexus;
        [NMS(Index = 1)]
        /* 0x1 */ public bool PlanetMustHaveNPCs;
    }
}
