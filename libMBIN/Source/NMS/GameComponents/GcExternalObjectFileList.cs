using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcExternalObjectFileList : NMSTemplate
    {
        public float ProbabilityOfBeingActive;
        public int MinFilesToChoose;
        public int MaxFilesToChoose;

        public List<GcExternalObjectListOptions> ExternalObjectFiles;

    }
}
