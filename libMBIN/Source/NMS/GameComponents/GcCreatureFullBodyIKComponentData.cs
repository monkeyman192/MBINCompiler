using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x337F45FFED97901C, NameHash = 0x741554C15123D097)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate        // size: 0x18
    {
        public List<GcCreatureIkData> JointData;
		public enum HeadUpAxisEnum { X, XNeg, Y, YNeg, Z, ZNeg }
		public HeadUpAxisEnum HeadUpAxis;

        public bool UseFootGlue;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
