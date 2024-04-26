using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCF02F7B7FB501FAB, NameHash = 0x3F42E6C415489AAF)]
    public class TkMetadataFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x80> Filenames;
    }
}
