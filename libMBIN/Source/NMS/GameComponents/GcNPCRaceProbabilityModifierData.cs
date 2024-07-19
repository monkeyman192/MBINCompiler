using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF577491893D64FFC, NameHash = 0x74B595C4)]
    public class GcNPCRaceProbabilityModifierData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Modifier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcAlienRace Race;
    }
}
