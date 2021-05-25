using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x901EC91DF16D7A41, NameHash = 0x9A637E59AB66BFB0)]
    public class GcAlienMood : NMSTemplate
    {
        // size: 0x9
        public enum MoodEnum { Neutral, Positive, VeryPositive, Negative, VeryNegative, Pity, Sad, Dead, Confused }
        public MoodEnum Mood;
    }
}