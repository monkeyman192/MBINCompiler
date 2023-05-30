using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPainAction : NMSTemplate
    {
        public NMSString0x10 Damage;
        public float Radius;
        public bool AffectsPlayer;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
