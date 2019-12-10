using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x320, GUID = 0xAED7A5A095C6D0FE, NameHash = 0x56B367D500FF0878)]
    public class GcAtlasSendSubmitBaseWithImage : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public GcAtlasSendSubmitBase Base;
        /* 0x310 */ public List<byte> Image;        // This is not the correct type. The data will literally be the data for the image itself.
        // The above data type is the same as the MeshDataStream in the TkMeshData...
    }
}
