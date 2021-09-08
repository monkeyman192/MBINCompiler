using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x330, GUID = 0x963C7E5CA4F0DE75, NameHash = 0x56B367D500FF0878)]
    public class GcAtlasSendSubmitBaseWithImage : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x000 */ public byte[] Padding0;
        /* 0x008 */ public ulong ClientUserdata;
        /* 0x010 */ public GcAtlasSendSubmitBase Base;
        /* 0x320 */ public List<byte> Image;        // This is not the correct type. The data will literally be the data for the image itself.
        // The above data type is the same as the MeshDataStream in the TkMeshData...
    }
}
