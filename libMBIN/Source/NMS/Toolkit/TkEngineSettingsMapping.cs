using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x58, GUID = 0x56C366D62468C620, NameHash = 0xC02F1D19584B44D)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public float[] ShadowMultiplier;
        [NMS(Size = 0x4)]
        public float[] ReflectionMultiplier;
        [NMS(Size = 0x4)]
        public float[] IKFullBodyIterations;

        // boolean describing whether or not the game needs to restant when the specific setting has been changed... I think...
        [NMS(Size = 0x27, EnumType = typeof(TkEngineSettingTypes.EngineSettingEnum))]
        public bool[] NeedsGameRestart;
        [NMS(Size = 0x1, Ignore = true)]
        public byte[] EndPadding;
    }
}
