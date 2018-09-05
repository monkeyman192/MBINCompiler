namespace libMBIN.Models.Structs
{
    public class GcWeightingCurve : NMSTemplate
    {
        public int WeightingCurve;

        public string[] WeightingCurveValues()
        {
            return new[] { "NoWeighting", "MaxIsUncommon", "MaxIsRare", "MaxIsSuperRare", "MinIsUncommon", "MinIsRare", "MinIsSuperRare"};
        }
    }
}
