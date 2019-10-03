using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x262A0, GUID = 0x60CAFAD6AA17AC28, NameHash = 0xF0829DCD8555A52E)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x26220 */ public GcPlayerSpawnStateData Spawn;
    }
}
