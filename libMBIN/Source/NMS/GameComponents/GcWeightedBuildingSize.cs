using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4ABC149C939922B8, NameHash = 0x90DB43477E714E6D)]
    public class GcWeightedBuildingSize : NMSTemplate
    {
        /* 0x00 */ public float RelativeProbability;
        /* 0x04 */ public int SizeX;
        /* 0x08 */ public int SizeY;
        /* 0x0C */ public int SizeZ;
        /* 0x10 */ public bool CreateSymmetricBuilding;
    }
}
