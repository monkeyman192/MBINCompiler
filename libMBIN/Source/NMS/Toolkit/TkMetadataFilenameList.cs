using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x1833EB5E25255C7E, NameHash = 0x3F42E6C415489AAF)]
    public class TkMetadataFilenameList : NMSTemplate
    {
        public List<NMSString0x80> Filenames;
    }
}
