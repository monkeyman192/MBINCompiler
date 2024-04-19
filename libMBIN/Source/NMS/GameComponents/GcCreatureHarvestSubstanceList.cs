namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE886E62858AFB688, NameHash = 0xC8FD5EE28A99CF03)]
    public class GcCreatureHarvestSubstanceList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CreatureType;
        /* 0x10 */ public NMSString0x10 Item;
        /* 0x20 */ public int MinBlobs;
        /* 0x24 */ public NMSString0x80 Desc;
    }
}
