using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x8159D3D6B6276FF1, NameHash = 0x5035CC19B55D3442)]
    public class GcSelectableObjectList : NMSTemplate
    {
        public NMSString0x10 Name;
        public GcAlienRace Race;
        public List<GcSelectableObjectData> Options;
    }
}