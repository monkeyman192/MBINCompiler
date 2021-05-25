using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x68D6ADC8973A8BF8, NameHash = 0xB1B9570C76B5EA49)]
    public class GcFrigateFlybyLayout : NMSTemplate
    {
        /* 0x0 */ public GcFrigateFlybyType FlybyType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding;
        /* 0x8 */ public List<GcFrigateFlybyOption> Frigate;
    }
}
