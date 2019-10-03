using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x88B80, GUID = 0x5F9558C1F183E6F2, NameHash = 0xA9237A301B5A6C2F)]
    public class TkInputFrameArray : NMSTemplate
    {
        [NMS(Size = 0x4E20)] // INPUTTEST.MBIN has a different count of these? uncertain because we can't tell the MBIN header size..
        public TkInputFrame[] Array;
    }
}
