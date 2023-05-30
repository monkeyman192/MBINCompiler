using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkTrophyEntry : NMSTemplate
    {
        public NMSString0x10 TrophyId;
        public int Ps4Id;
        public NMSString0x40 PCId;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding54;
    }
}
