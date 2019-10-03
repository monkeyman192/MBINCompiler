using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xC, GUID = 0x522802FFC949E6C6, NameHash = 0x19B524BD08F5E823)]
    public class TkAnimDetailSettingsData : NMSTemplate
    {
        public float Distance;
        public bool DisableAnims;
        public int NumCulledFrames;
    }
}
