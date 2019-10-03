using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5DDBF9992E6372C6, NameHash = 0xBE2904B2E88160B7)]
    public class GcRewardCompleteMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
    }
}
