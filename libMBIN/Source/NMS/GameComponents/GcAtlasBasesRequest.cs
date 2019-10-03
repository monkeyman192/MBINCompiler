using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4C, GUID = 0xEFD483DB2C4E4755, NameHash = 0x1E454D73CB415CEA)]
    public class GcAtlasBasesRequest : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        public GcGameMode GameMode;
        public int MaxResults;
        public int MayBytes;
        public int MinVersion;
        public int MaxVersion;
        [NMS(Size = 0x20)]
        public string SpecificUserId;
    }
}
