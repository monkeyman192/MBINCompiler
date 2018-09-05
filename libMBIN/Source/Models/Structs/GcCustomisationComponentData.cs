namespace libMBIN.Models.Structs
{
    public class GcCustomisationComponentData : NMSTemplate
    {
        public int CustomisationDataType;
        public string[] CustomisationDataTypeValues()
        {
            return new[] { "Player", "Vehicle", "Weapon", "Ship_01", "Ship_02", "Ship_03", "Ship_04", "Ship_05", "Ship_06" };
        }
    }
}
