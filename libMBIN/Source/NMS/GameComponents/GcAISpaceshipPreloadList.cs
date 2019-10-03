using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7A792008B203503F, NameHash = 0xC546551B048ACC33)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        public GcRealityCommonFactions Faction;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public List<GcAISpaceshipPreloadCacheData> Cache;
    }
}
