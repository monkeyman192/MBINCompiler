using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7744F71486CD147D, NameHash = 0x4F6F7504AD1EBFFC)]
    public class GcBaseBuildingPartData : NMSTemplate
    {
        /* 0x00 */ public TkMagicModelData MagicData;
        /* 0x30 */ public NMSString0x20A PartID;
        /* 0x50 */ public ulong InstanceLastProfiledTimestamp;
        /* 0x58 */ public ulong LastProfiledTimestamp;
        /* 0x60 */ public uint InstanceMeshesCost;
        /* 0x64 */ public uint InstanceNodesCost;
        /* 0x68 */ public uint InstanceTimeCost;
        /* 0x6C */ public uint MeshesCost;
        /* 0x70 */ public uint NodesCost;
        /* 0x74 */ public uint PhysicsCost;
        /* 0x78 */ public GcBaseBuildingPartStyle Style;
        /* 0x7C */ public uint TimeCost;
    }
}
