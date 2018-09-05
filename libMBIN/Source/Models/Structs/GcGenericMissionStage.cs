using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x58)]
    public class GcGenericMissionStage : NMSTemplate
    {
        public List<GcGenericMissionVersionProgress> Versions;
        public NMSTemplate Stage;
    }
}
