using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCF02F7B7FB501FAB, NameHash = 0x4775FB9B)]
    public class TkMetadataFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<VariableSizeString> Filenames;
    }
}
