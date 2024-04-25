namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83AB64738650BC1D, NameHash = 0xCBF38A24719D032E)]
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        // size: 0x7
        public enum BaseBuildingDecorationTypeEnum : uint {
            Normal,
            SurfaceNormal,
            Ceiling,
            Terrain,
            Substance,
            Plant,
            BuildingSurfaceNormal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingDecorationTypeEnum BaseBuildingDecorationType;
    }
}
