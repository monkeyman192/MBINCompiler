using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatDefinition : NMSTemplate
    {
        public GcStatType Type;
        public GcStatTrackType TrackType;
        public GcStatDisplayType DisplayType;
        public GcStatValueData DefaultValue;

        public NMSString0x10 Id;
    }
}
