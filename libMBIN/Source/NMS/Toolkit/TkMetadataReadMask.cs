using System;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x4DEB11EC99BFE346, NameHash = 0x76BB9C78D7AE1C6B)]
    public class TkMetadataReadMask : NMSTemplate
    {
        [Flags]
        public enum MetadataReadMaskEnum { Default = 0x01, SaveWhenMultiplayerClient = 0x02, SavePlayerPosition = 0x04, SavePlayerInventory = 0x08 }
        [NMSDescription("The enum that describes this field uses flags. This means that multiple values may be specified simultaneously" +
                        "by using the notation 'Default|SavePlayerPosition'. Ie. split values with a | character")]
        public MetadataReadMaskEnum MetadataReadMask;
    }
}
