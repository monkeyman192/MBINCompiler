namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x5A0)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0xC)]
        public GcPlayerCharacterState[] CharacterStates;
    }
}
