using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x21E266137C8188B8, NameHash = 0xF5980A36D3152438)]
    public class TkAnimPoseExampleElement : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public float Value;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
