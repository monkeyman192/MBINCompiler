using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        public NMSString0x10 Id;

        public GcAlienRace AlienRace;
        public GcInteractionType InteractionType;

        public NMSString0x200 Text;

        public NMSString0x200 TextAlien;

        public bool TranslateAlienText;
        public List<GcAlienPuzzleOption> Options;
    }
}
