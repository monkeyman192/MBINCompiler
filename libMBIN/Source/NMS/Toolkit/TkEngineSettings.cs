using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    // doesn't seem to be used by the game, TkEngineSettings template isn't inside the exe
    // and the only file using this template (METADATA/ENGINE/TKENGINESETTINGS.MBIN) isn't referenced
    // file is probably a leftover from early development

    public class TkEngineSettings : NMSTemplate
    {
        public float ScreenWidth;
        public float ScreenHeight;
    }
}
