using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x345A7872919A67E5, NameHash = 0xF584C2AF)]
    public class TkMeshWaterQualitySettings : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x00 */ public TkMeshWaterQualitySettingData[] MeshWaterQualitySettings;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x90 */ public TkMeshWaterReflectionQualitySettingData[] MeshWaterReflectionQualitySettings;
    }
}
