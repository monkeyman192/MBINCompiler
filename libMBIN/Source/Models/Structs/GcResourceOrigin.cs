namespace libMBIN.Models.Structs
{
    public class GcResourceOrigin : NMSTemplate
    {
		public enum ResourceOriginEnum { Terrain, Crystal, Asteroid, Robot, Depot }
		public ResourceOriginEnum ResourceOrigin;
    }
}
