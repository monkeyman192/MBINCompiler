using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77725A322F5E2BE8, NameHash = 0x1D3FECE6AC6A7E9F)]
    public class GcByteBeatLibraryData : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x0000 */ public GcByteBeatSong[] MySongs;
        [NMS(Size = 0x10)]
        /* 0x1900 */ public NMSString0x10[] Playlist;
        /* 0x1A00 */ public bool AutoplayInShip;
        /* 0x1A01 */ public bool AutoplayInVehicle;
        /* 0x1A02 */ public bool AutoplayOnFoot;
        /* 0x1A03 */ public bool Shuffle;
    }
}
