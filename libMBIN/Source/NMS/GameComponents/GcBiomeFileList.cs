using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, GUID = 0x73D64DB7C6194A4A)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS( EnumType = typeof( GcBiomeType.BiomeEnum ) )]
        /* 0x00 */ public GcBiomeFileListOptions[] BiomeFiles;

        /* 0xD0 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0xE0 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
