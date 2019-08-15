﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF2734EF6AF1583B6)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}
