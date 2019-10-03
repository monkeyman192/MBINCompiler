using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x236A8FA0D9098F3F, NameHash = 0x1FE13AB26770D8C5)]
    public class GcScanEffectComponentData : NMSTemplate
    {
        public List<GcScanEffectData> ScanEffects;
        [NMS(Size = 0x40)]
        public string NodeName;
    }
}
