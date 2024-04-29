using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBBEEEE3D934E055A, NameHash = 0xDE03C95CFD766DA8)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x12, EnumType = typeof(GcPlayerCharacterStateType.CharacterStateEnum))]
        /* 0x0 */ public GcPlayerCharacterStateData[] CharacterStates;
    }
}
