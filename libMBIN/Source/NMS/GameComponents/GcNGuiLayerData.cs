using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiLayerData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiGraphicStyle Style;
        public NMSString0x80 Image;
        public List<NMSTemplate> Children;
        public NMSString0x80 DataFilename;
    }
}
