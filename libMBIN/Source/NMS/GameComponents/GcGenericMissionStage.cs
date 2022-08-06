using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE47DADDDF1545211, NameHash = 0xE8F2F4C4A2F01AD1)]
    public class GcGenericMissionStage : NMSTemplate
    {
        public List<GcGenericMissionVersionProgress> Versions;
        public NMSTemplate Stage;
    }
}
