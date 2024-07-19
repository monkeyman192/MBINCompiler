namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73E857AA26F65CCE, NameHash = 0x3E17CC26)]
    public class GcCreatureHarvestSubstanceList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CreatureType;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Item;
        [NMS(Index = 3)]
        /* 0x20 */ public int MinBlobs;
        [NMS(Index = 2)]
        /* 0x24 */ public NMSString0x80 Desc;
    }
}
