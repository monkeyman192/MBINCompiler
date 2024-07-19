using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2115918A9FF4213B, NameHash = 0x588D69C1)]
    public class GcByteBeatLibraryData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8)]
        /* 0x0000 */ public GcByteBeatSong[] MySongs;
        [NMS(Index = 1, Size = 0x10)]
        /* 0x1900 */ public NMSString0x10[] Playlist;
        [NMS(Index = 4)]
        /* 0x1A00 */ public bool AutoplayInShip;
        [NMS(Index = 5)]
        /* 0x1A01 */ public bool AutoplayInVehicle;
        [NMS(Index = 3)]
        /* 0x1A02 */ public bool AutoplayOnFoot;
        [NMS(Index = 2)]
        /* 0x1A03 */ public bool Shuffle;
    }
}
