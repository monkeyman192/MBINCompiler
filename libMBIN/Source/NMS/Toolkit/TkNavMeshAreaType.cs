namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9B522650EBAFE147, NameHash = 0xDCBDDB64)]
    public class TkNavMeshAreaType : NMSTemplate
    {
        // size: 0x16
        public enum NavMeshAreaTypeEnum : byte {
            Null,
            Grass,
            Rock,
            Snow,
            Mud,
            Sand,
            Cave,
            Forest,
            Wetlands,
            Mistlands,
            GrassAlt,
            RockAlt,
            ForestAlt,
            MudAlt,
            Soil,
            Resource,
            TerrainInstance,
            Structure,
            ShallowWater,
            Water,
            Auto,
            UseTerrainMaterialId,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaTypeEnum NavMeshAreaType;
    }
}
