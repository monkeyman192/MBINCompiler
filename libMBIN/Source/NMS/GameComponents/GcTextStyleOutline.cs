using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x68F78A981C698B29, NameHash = 0x7D4F735E42D738AE)]
    public class GcTextStyleOutline : NMSTemplate
    {
        public Colour OutlineColour;
        public Vector2f OutlineOffset;
    }
}