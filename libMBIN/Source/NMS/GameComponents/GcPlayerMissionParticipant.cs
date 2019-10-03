using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x6B43B59D0BE1F53C, NameHash = 0xB223E7785971518B)]
    public class GcPlayerMissionParticipant : NMSTemplate
    {
        /* 0x00 */ public ulong UA;
        /* 0x08 */ public GcSeed BuildingSeed;
        /* 0x20 */ public Vector3f BuildingLocation;
        /* 0x30 */ public GcPlayerMissionParticipantType ParticipantType;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x34 */ public byte[] EndPadding;
    }
}
