using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 8)]
        public NMSString0x80[] BiomeFiles;

        public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
