using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6658083772173E22, NameHash = 0x4F0D63A1)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x12, EnumType = typeof(GcPlayerCharacterStateType.CharacterStateEnum))]
        /* 0x0 */ public GcPlayerCharacterStateData[] CharacterStates;
    }
}
