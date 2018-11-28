using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents {

	[NMS( Size = 0x1C0, GUID = 0xA8879B14156D70FE)]
    public class GcInventoryLayoutGenerationData : NMSTemplate {

        [NMS( EnumType = typeof( GcInventoryLayoutSizeType.SizeTypeEnum ) )]
        public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;

    }

}
