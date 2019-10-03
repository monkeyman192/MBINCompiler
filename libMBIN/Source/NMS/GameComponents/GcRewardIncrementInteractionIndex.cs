using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5413B435C9CD8249, NameHash = 0x317FB72CFB424340)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        public GcInteractionType InteractionToIncrement;
        public GcAlienRace Race;
    }
}
