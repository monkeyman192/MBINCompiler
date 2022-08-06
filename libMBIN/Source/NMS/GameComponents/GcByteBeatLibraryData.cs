using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5EC5FDC9A08965A, NameHash = 0x1D3FECE6AC6A7E9F)]
    public class GcByteBeatLibraryData : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x0000 */ public GcByteBeatSong[] MySongs;
        [NMS(Size = 0x10)]
        /* 0x1900 */ public NMSString0x10[] Playlist; 
        /* 0x1A00 */ public bool Shuffle;
        /* 0x1A01 */ public bool AutoplayOnFoot;
        /* 0x1A02 */ public bool AutoplayInShip;
        /* 0x1A03 */ public bool AutoplayInVehicle;
    }
}
