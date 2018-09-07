namespace libMBIN.Models.Structs
{
    public class TkGameSettings : NMSTemplate
    {
		public enum LanguageSettingEnum { Default, english, french, italian, german, spanish, russian, polish, dutch, portuguese, brazilianportuguese, japanese, traditionalchinese, simplifiedchinese, korean }
		public LanguageSettingEnum LanguageSetting;

        [NMS(Size = 0x1F, EnumValue = new[] { "Player_Forward", "Player_Back", "Player_Left", "Player_Right", "Player_SwimUp", "Player_SwimDown", "Player_Interact", "Player_Melee", "Player_Scan", "Player_Torch", "Player_Binoculars", "Player_Zoom", "Player_ShowHUD", "Player_Jump", "Player_Run", "Player_Shoot", "Player_Grenade", "Player_Reload", "Player_ChangeWeapon", "Ship_Thrust", "Ship_Brake", "Ship_Boost", "Ship_RollLeft", "Ship_RollRight", "Ship_Exit", "Ship_Land", "Ship_Shoot", "Ship_ChangeWeapon", "Ship_Scan", "Ship_PulseJump", "Ship_GalacticMap" })]
        public GcInputActionMapping[] KeyMapping;
    }
}
