using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x18, GUID = 0x674E443873C61AA4, NameHash = 0x57A3CABFA5A7BDA8)]
    public class TkAnimPoseBabyModifier : NMSTemplate
    {
        public NMSString0x10 Item;
        public float Value;
        public float Weight;
    }
}
