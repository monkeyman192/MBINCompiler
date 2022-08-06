using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2037639D75C35599, NameHash = 0x4D3FB3BF1BEB7DAE)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        public GcPlayerCharacterStateType State;
        public GcPlayerCharacterIKOverrideData Data;
        public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
    }
}
