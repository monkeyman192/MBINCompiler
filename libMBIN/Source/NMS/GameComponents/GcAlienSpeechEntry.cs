using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAlienSpeechEntry : NMSTemplate
    {
        public NMSString0x10 Id;

        public NMSString0x20 Text;

        public int WordInteractEffect;

        public string[] WordInteractEffectValues()
        {
            return new[] { "Pain", "Heal" };
        }

        public GcAlienRace AlienRace;
        public int Level;
        [NMS(Ignore = true)]
        public int Padding;
    }
}
