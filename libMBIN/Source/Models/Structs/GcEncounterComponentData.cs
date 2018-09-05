namespace libMBIN.Models.Structs
{
    public class GcEncounterComponentData : NMSTemplate
    {
        public int EncounterType;
        public string[] EncounterTypeValues()
        {
            return new[] { "FactoryGuards", "HarvesterGuards" };
        }
    }
}
