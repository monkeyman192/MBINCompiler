using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x4485081ABCC6928D, NameHash = 0xDACE1F471447B685)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        // 0x12 entries
		public enum CharacterStateEnum {
            Idle, Jog, JogUphill, JogDownhill, SteepSlope, Sliding, Run, Airborne, JetpackBoost, RocketBoots,
            Riding, Swimming, SwimmingJetpack, Death, FullBodyOverride, InSpace, LowGWalk, LowGRun
        }
		public CharacterStateEnum CharacterState;
    }
}