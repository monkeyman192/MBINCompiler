using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnPlayAnim_short : NMSTemplate
    {
        // This is a weird case where the PlayAnim data is only 0x10 long. This isn't in the exe and is only one file. Maybe the file is old.
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Anim;
        // IONode: Out: 0: Src, 1: Anim
    }
}
