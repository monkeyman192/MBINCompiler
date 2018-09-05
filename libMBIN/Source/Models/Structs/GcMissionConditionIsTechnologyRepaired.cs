namespace libMBIN.Models.Structs
{
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;        // I bet this has got bigger...
        public int RepairedComponents;
    }
}
