using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x622F8F6552A40D7E, NameHash = 0x8E2443E0F5BE1DD5)]
    public class GcGenericMissionVersionProgress : NMSTemplate
    {
        public int Version;
        public int Progress;
    }
}
