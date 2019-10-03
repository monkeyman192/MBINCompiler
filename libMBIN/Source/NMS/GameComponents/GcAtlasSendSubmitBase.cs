using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2F0, GUID = 0x4F2396F9FE1F5E73, NameHash = 0xF6415333939D5563)]
    public class GcAtlasSendSubmitBase : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserdata;
        /* 0x008 */ public GcGameMode GameMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C */ public byte[] PaddingC;
        /* 0x010 */ public GcPersistentBase BaseData;
        /* 0x2B0 */ public GcAtlasRecvBlob TerrainData;
    }
}
