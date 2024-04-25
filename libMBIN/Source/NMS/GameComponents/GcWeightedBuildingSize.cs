namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC7CD8229B1A09FC, NameHash = 0x90DB43477E714E6D)]
    public class GcWeightedBuildingSize : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float RelativeProbability;
        [NMS(Index = 1)]
        /* 0x04 */ public int SizeX;
        [NMS(Index = 2)]
        /* 0x08 */ public int SizeY;
        [NMS(Index = 3)]
        /* 0x0C */ public int SizeZ;
        [NMS(Index = 4)]
        /* 0x10 */ public bool CreateSymmetricBuilding;
    }
}
