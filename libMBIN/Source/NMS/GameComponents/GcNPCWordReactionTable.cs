using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7D1584C03A3BC81B, NameHash = 0xB4578AF4AEBD0B11)]
    public class GcNPCWordReactionTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        public GcNPCWordReactionCategory[] Races;
    }
}
