namespace libMBIN.Models.Structs
{
    public class GcRewardTeleport : NMSTemplate
    {
		public enum TeleportRewardTypeEnum { None, ToBase, Station0, Station1, Station2, Station3, Atlas }
		public TeleportRewardTypeEnum TeleportRewardType;
    }
}
