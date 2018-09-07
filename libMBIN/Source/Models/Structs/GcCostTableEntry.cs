namespace libMBIN.Models.Structs
{
    public class GcCostTableEntry : NMSTemplate     // size: 0x60
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public bool DisplayCost;
        /* 0x11 */ public bool DontCharge;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] Padding12;
        /* 0x18 */ public NMSTemplate Cost;
    }
}
