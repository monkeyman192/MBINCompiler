namespace libMBIN.Models.Structs
{
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
        public int IndexType;
        public string[] IndexTypeValues()
        {
            return new[] { "Regular", "Seeded"};
        }
    }
}
