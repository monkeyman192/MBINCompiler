using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9FD9F932AF6778C8, NameHash = 0x1E454D73CB415CEA)]
    public class GcAtlasBasesRequest : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        public GcGameMode GameMode;
        public int MaxResults;
        public int MaxBytes;
        public int MinVersion;
        public int MaxVersion;
        public NMSString0x20 SpecificUserId;
    }
}
