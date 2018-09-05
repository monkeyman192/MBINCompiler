using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcRewardUpgradeBase : NMSTemplate
    {
        public int UpgradeBaseType;
        public string[] UpgradeBaseTypeValues()
        {
            return new[] { "AllMatching", "NearestMatching" };
        }
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public TkResourceFilterList MatchingBaseTypes;
    }
}
