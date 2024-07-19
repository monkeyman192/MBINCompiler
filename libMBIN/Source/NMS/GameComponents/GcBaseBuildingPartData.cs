using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B0729744AAA1CA5, NameHash = 0xB3487ADB)]
    public class GcBaseBuildingPartData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkMagicModelData MagicData;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x20A PartID;
        [NMS(Index = 11)]
        /* 0x50 */ public ulong InstanceLastProfiledTimestamp;
        [NMS(Index = 10)]
        /* 0x58 */ public ulong LastProfiledTimestamp;
        [NMS(Index = 9)]
        /* 0x60 */ public uint InstanceMeshesCost;
        [NMS(Index = 7)]
        /* 0x64 */ public uint InstanceNodesCost;
        [NMS(Index = 8)]
        /* 0x68 */ public uint InstanceTimeCost;
        [NMS(Index = 6)]
        /* 0x6C */ public uint MeshesCost;
        [NMS(Index = 3)]
        /* 0x70 */ public uint NodesCost;
        [NMS(Index = 5)]
        /* 0x74 */ public uint PhysicsCost;
        [NMS(Index = 1)]
        /* 0x78 */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 4)]
        /* 0x7C */ public uint TimeCost;
    }
}
