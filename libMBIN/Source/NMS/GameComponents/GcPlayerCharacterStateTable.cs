using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xBD0, GUID = 0x70FCB377A9D4E58C, NameHash = 0xDE03C95CFD766DA8)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0x12, EnumType = typeof(GcPlayerCharacterStateType.CharacterStateEnum))]
        public GcPlayerCharacterStateData[] CharacterStates;
    }
}
