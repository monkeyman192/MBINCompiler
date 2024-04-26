namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28FD8E5FE5649E4B, NameHash = 0x1A9351C5A8C07BA4)]
    public class GcCharacterControlInputValidity : NMSTemplate
    {
        // size: 0x3
        public enum CharacterControlInputValidityEnum : uint {
            Always,
            PadOnly,
            KeyboardAnMouseOnly,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CharacterControlInputValidityEnum CharacterControlInputValidity;
    }
}
