namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x528)]
    public class GcLeveledStatData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string StatId;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string StatTitle;
        /* 0x030 */ public int StatMessageType;
        public string[] StatMessageTypeValues()
        {
            return new[] { "Full", "Quick", "Silent"};
        }
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x034 */ public byte[] Padding34;
        [NMS(Size = 0x20)]
        /* 0x038 */ public string NotifyMessage;
        [NMS(Size = 0x20)]
        /* 0x058 */ public string NotifyMessageSingular;

        /* 0x078 */ public bool ShowInTerminal;
        /* 0x079 */ public bool ShowStatLevel;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x07A */ public byte[] Padding7A;
        /* 0x07C */ public TkTextureResource Icon;
        [NMS(Size = 0xB)]
        /* 0x100 */ public GcStatLevelData[] StatLevels;
        /* 0x520 */ public bool UseRankNotStats;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x521 */ public byte[] EndPadding;
    }
}
