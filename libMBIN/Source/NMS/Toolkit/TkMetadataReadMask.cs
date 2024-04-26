using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE5E072016B296CBC, NameHash = 0x76BB9C78D7AE1C6B)]
    public class TkMetadataReadMask : NMSTemplate
    {
        // size: 0x5
        [Flags]
        public enum MetadataReadMaskEnum : uint {
            Default = 0x1,
            SaveWhenMultiplayerClient = 0x2,
            SavePlayerPosition = 0x4,
            SavePlayerInventory = 0x8,
            SaveDifficultySettings = 0x10,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MetadataReadMaskEnum MetadataReadMask;
    }
}
