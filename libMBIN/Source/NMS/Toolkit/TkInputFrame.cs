using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x46FE92211FE98307, NameHash = 0xF3DC604B80A24AD)]
    public class TkInputFrame : NMSTemplate
    {
        public Vector2f LeftStick;
        public Vector2f RightStick;
        public float LeftTrigger;
        public float RightTrigger;
        public short Buttons;
    }
}
