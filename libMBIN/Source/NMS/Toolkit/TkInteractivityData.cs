using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x209CCBD02527DE07, NameHash = 0x8BA785D3F3AE4D34)]
    public class TkInteractivityData : NMSTemplate
    {
        public List<TkInteractiveSceneData> Scenes;
    }
}
