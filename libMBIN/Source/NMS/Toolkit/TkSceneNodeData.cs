using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkSceneNodeData : NMSTemplate
    {
        public NMSString0x80 Name;
        public NMSString0x10 Type;
        public TkTransformData Transform;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        public List<TkSceneNodeAttributeData> Attributes;
        public List<TkSceneNodeData> Children;
    }
}
