using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A35B9B8FCE6DD42, NameHash = 0xB764F802BDE36ADF)]
    public class GcByteBeatTemplate : NMSTemplate
    {
        public float Weight;
        public GcByteBeatToken TokenType;
        public int MinValue;
        public int MaxValue;
        public List<GcByteBeatTemplate> Children;
    }
}
