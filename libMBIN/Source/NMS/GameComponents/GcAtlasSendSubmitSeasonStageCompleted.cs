using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E31B1DF93F2028A, NameHash = 0x28ADD037AEDE77EB)]
    public class GcAtlasSendSubmitSeasonStageCompleted : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int SeasonID;
        /* 0x14 */ public int StageID;
    }
}
