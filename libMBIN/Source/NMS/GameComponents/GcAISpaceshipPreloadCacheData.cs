using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        public GcAISpaceshipRoles ShipRole;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public GcSeed Seed;
        public NMSString0x100 AltId;
    }
}
