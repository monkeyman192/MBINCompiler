using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x616B8FA52AC3D04D, NameHash = 0xF14D3F32)]
    public class GcGenericMissionStage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSTemplate Stage;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcGenericMissionVersionProgress> Versions;
    }
}
