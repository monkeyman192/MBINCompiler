using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x9BC78147660AB1EA, NameHash = 0x0FEF6F10412C7B60)]
    public class TkGridLayersEnum : NMSTemplate
    {
        // size: 0x9
        public enum GridLayerTypesEnum { Small, Large, Resources_Heridium, Resources_Iridium, Resources_Copper, Resources_Nickel, Resources_Aluminium, Resources_Gold, Resources_Emeril }
        public GridLayerTypesEnum GridLayerTypes;
    }
}
