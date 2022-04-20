﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xB71F79F06005B225, NameHash = 0xDBD890CF58AC39B5)]
    public class GcTileTypeOptions : NMSTemplate
    {
        /* 0x0 */ public List<TkPaletteTexture> Options;
    }
}
