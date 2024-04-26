using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA464AF961B75371B, NameHash = 0x7C31C15F3BD6DD7E)]
    public class GcNPCRaceProbabilityModifierData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Modifier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcAlienRace Race;
    }
}
