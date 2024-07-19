namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB81DE26A5931326, NameHash = 0xF895D303)]
    public class GcCharacterControlOutputSpace : NMSTemplate
    {
        // size: 0x3
        public enum CharacterControlOutputSpaceEnum : uint {
            CameraRelative,
            CameraRelativeTopDown,
            Raw,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CharacterControlOutputSpaceEnum CharacterControlOutputSpace;
    }
}
