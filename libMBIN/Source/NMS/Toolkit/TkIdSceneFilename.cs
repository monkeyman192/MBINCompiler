using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x90, GUID = 0x2850C6AD91A257FE, NameHash = 0x122FE9C1D39C44F6)]
    public class TkIdSceneFilename : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x80 Filename;
    }
}
