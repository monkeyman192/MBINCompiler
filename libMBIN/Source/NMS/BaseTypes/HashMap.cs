namespace libMBIN.NMS {

    [NMS(Size = 0x30)]
    public class HashMap<T> : NMSTemplate
    {
        /* 0x00 */ public ulong Offset;
        /* 0x08 */ public uint Count;
        /* 0x0C */ public uint EndPaddingLShift;  // This is the size of the end padding blob. Ie. size = 8 << EndPaddingLShift
        // To write this value. We calculate the smallest `n` such that (8 << n) > 8 * Count

        // It looks like there are then 4 uint64's which correspond to something... They seem to be empty in the mbins though.
        [NMS(Size = 0x20)]
        /* 0x10 */ public byte[] EndPadding;
    }
}
