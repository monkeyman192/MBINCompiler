using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xF9E364878E24F868, NameHash = 0xCD3485C140AE7B57)]
    public class GcPersistentBBObjectData : NMSTemplate // size = 0x60
    {
        /* 0x00 */ public ulong Timestamp;
        /* 0x08 */ public NMSString0x10 ObjectId;
        /* 0x18 */ public ulong GalacticAddress;
        /* 0x20 */ public ulong RegionSeed;
        /* 0x28 */ public ulong UserData;
        /* 0x30 */ public Vector4f Position;
        /* 0x40 */ public Vector4f Up;
        /* 0x50 */ public Vector4f At;
    }
}