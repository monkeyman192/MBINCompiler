using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x805535732C4553F5, NameHash = 0x17FDBAA75DF0569B)]
    public class GcCharacterControlOutputSpace : NMSTemplate
    {
        // size: 0x3
        public enum CharacterControlOutputSpaceEnum { CameraRelative, CameraRelativeTopDown, Raw }
        public CharacterControlOutputSpaceEnum CharacterControlOutputSpace;
    }
}
