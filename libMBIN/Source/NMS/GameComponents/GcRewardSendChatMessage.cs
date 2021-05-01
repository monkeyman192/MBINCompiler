﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xED2E57A7986885BA, NameHash = 0x64C12702D824E202)]
    public class GcRewardSendChatMessage : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatusMessageId;
        [NMS(Size = 0x20)]
        public string CustomText;
    }
}