using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x50)]
    public class TkAnim2dBlendNodeData : NMSTemplate
    {
        public Vector2f Position;
        public NMSTemplate BlendChild;
    }
}
