using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x609A8B6540C477F0, NameHash = 0xB64408EDDD99E644)]
    public class GcWordGroupKnowledge : NMSTemplate
    {
        public NMSString0x20A Group;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        public bool[] Races;
    }
}
