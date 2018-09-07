namespace libMBIN.Models.Structs
{
    public class GcWeightingCurve : NMSTemplate
    {

		public enum WeightingCurveEnum { NoWeighting, MaxIsUncommon, MaxIsRare, MaxIsSuperRare, MinIsUncommon, MinIsRare, MinIsSuperRare }
		public WeightingCurveEnum WeightingCurve;
    }
}
