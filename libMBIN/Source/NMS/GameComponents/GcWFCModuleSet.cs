using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94BFF1BF30BC4484, NameHash = 0x12D00A471DB28074)]
    public class GcWFCModuleSet : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public Vector3f BlockSize;
        /* 0x30 */ public bool ApplyWallThemes;
        /* 0x38 */ public List<GcWFCModulePrototype> ModulePrototypes;
        /* 0x48 */ public List<NMSString0x20> ConnectorsOnUpperBoundary;
        /* 0x58 */ public List<NMSString0x20> ConnectorsOnLowerBoundary;
        /* 0x68 */ public List<NMSString0x20> ConnectorsOnHorizontalBoundary;
        /* 0x78 */ public List<NMSString0x10> DefaultGroups;
        /* 0x88 */ public List<GcIDPair> CompatibleConnectors;
        /* 0x98 */ public float VerticalOffset;
    }
}
