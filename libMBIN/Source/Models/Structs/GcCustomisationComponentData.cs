namespace libMBIN.Models.Structs
{
    public class GcCustomisationComponentData : NMSTemplate
    {
		public enum CustomisationDataTypeEnum { Player, Vehicle, Weapon, Ship_01, Ship_02, Ship_03, Ship_04, Ship_05, Ship_06 }
		public CustomisationDataTypeEnum CustomisationDataType;
    }
}
