using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x75A7492E264F5958, NameHash = 0x8554BC1ADD990AB6)]
    public class GcCreatureHealthData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string HurtAnim;
        [NMS(Size = 0x10)]
        public string DeathAnim;
        [NMS(Size = 0x10)]
        public string DeathEffect;
        [NMS(Size = 0x10)]
        public string HurtAudio;
        [NMS(Size = 0x10)]
        public string DeathAudio;
    }
}
