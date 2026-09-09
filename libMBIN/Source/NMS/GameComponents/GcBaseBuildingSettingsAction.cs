using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB08AB2296AC03128, NameHash = 0x8598A836)]
    public class GcBaseBuildingSettingsAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkGraphicsDetailTypes MaxAffectedDetail;
        // size: 0x3
        public enum UseCorePartsOnlyEnum : uint {
            False,
            True,
            DontCare,
        }
        [NMS(Index = 0)]
        /* 0x8 */ public UseCorePartsOnlyEnum UseCorePartsOnly;
    }
}
