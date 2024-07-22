using System;
using System.Collections;
using System.Collections.Generic;

namespace libMBIN.NMS {

    [NMS(Size = 0x30, Alignment = 0x8)]
    public class HashMap<T> : NMSTemplate, IEnumerable<T>, IHashMap
    {
        public List<T> Elements;  // The actual elements of the HashMap.
        /* 0x00 */ private ulong Offset;
        /* 0x08 */ public uint Count {
            get {
                return (uint)Elements.Count;
            }
        }

        /* 0x0C */ public int EndPaddingLShift {
            get {
                int shifts = 62;
                while ((shifts > 0) && (1 << (64 - shifts)) * 0.8 < Count) shifts -= 1;
                return 64 - shifts;
            }
        }

        // It looks like there are then 4 uint64's which correspond to something... They seem to be empty in the mbins though.
        [NMS(Size = 0x20)]
        /* 0x10 */ private byte[] EndPadding;

        public object GetElements() {
            return Elements;
        }

        // IMPORTANT: If any further constructors are added with one argument, some code in NMSTemplate will break!
        // See DeserializeEXml method.
        public HashMap() {
            Elements = new List<T>();
        }

        public HashMap(List<T> lst) {
            Elements = lst;
        }

        public IEnumerator<T> GetEnumerator() {
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        public static implicit operator HashMap<T>(List<T> lst) => new HashMap<T>(lst);
        public static implicit operator List<T>(HashMap<T> hm) => hm.Elements;
    }
}
