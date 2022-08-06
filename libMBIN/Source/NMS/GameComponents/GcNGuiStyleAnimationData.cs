using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x91253F947A706088, NameHash = 0x7CC4297B73C8CB65)]
    public class GcNGuiStyleAnimationData : NMSTemplate
    {
        public float Length;
        public List<GcNGuiStyleAnimationKeyframeData> KeyFrames;
    }
}