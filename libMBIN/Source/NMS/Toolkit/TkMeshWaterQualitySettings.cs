using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEC8106E627E57657, NameHash = 0xF584C2AF)]
    public class TkMeshWaterQualitySettings : NMSTemplate
    {
        // size: 0x4
        public enum MeshWaterQualitySettingsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(MeshWaterQualitySettingsEnum))]
        /* 0x00 */ public TkMeshWaterQualitySettingData[] MeshWaterQualitySettings;
        // size: 0x4
        public enum MeshWaterReflectionQualitySettingsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(MeshWaterReflectionQualitySettingsEnum))]
        /* 0xB0 */ public TkMeshWaterReflectionQualitySettingData[] MeshWaterReflectionQualitySettings;
    }
}
