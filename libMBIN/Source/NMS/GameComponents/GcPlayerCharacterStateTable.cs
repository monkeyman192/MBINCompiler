using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x930, GUID = 0xA444343A8262A49C)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS( EnumType = typeof( GcPlayerCharacterStateType.CharacterStateEnum ) )]
        public GcPlayerCharacterState[] CharacterStates;
    }
}
