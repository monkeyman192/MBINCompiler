namespace libMBIN.Models.Structs
{
    public class GcNetworkInterpolationComponentData : NMSTemplate
    {
        public int SynchroniseScale;
        public string[] SynchroniseScaleValues()
        {
            return new[] { "Never", "Once", "Always" };
        }
    }
}
