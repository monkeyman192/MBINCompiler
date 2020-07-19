using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2A030, GUID = 0x26F85D2B332F8393, NameHash = 0xF0829DCD8555A52E)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x29F80 */ public GcPlayerSpawnStateData Spawn;
    }
}
