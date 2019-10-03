using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x609A8B6540C477F0, NameHash = 0xB64408EDDD99E644)]
    public class GcWordGroupKnowledge : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Group;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        public bool[] Races;
    }
}
