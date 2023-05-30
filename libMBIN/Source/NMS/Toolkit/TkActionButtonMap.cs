using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkActionButtonMap : NMSTemplate
    {
        public NMSString0x10 ActionId;
        public bool ScaleToFitFont;
        public TkInputEnum InputButton;
        public List<TkPlatformButtonPair> Platforms;
    }
}
