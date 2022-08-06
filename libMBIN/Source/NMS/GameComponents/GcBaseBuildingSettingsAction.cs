using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E2017CCF5342870, NameHash = 0x1250AC356CE3B7B)]
    public class GcBaseBuildingSettingsAction : NMSTemplate
    {
        public enum UseCorePartsOnlyEnum { False, True, DontCare }
        public UseCorePartsOnlyEnum UseCorePartsOnly;
        public TkGraphicsDetailTypes MaxAffectedDetail;
    }
}