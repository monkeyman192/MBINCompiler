using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x93EC6032E16C9265, NameHash = 0x904C594862FC894E)]
    public class GcRewardAssessCookedProduct : NMSTemplate
    {
        public int AmountWorst;
        public int AmountBad;
        public int AmountAverage;
        public int AmountGood;
        public int AmountBest;
        public int AmountBestUpper;
    }
}
