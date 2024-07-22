namespace libMBIN.NMS {

    [NMS(Size = 0x18)]
    public class HashedString : NMSTemplate, INMSVariableLengthString
    {
        public string Value;
        private ulong Offset;
        private uint Length;
        private uint Padding0xC = 0xAAAAAA01;
        private uint Padding0x14 = 0xAAAAAAAA;
        public string String {
            get => StringValue();
            set => Value = value;
        }

        public string StringValue()
        {
            return Value;
        }
        /// <summary>
        /// Jenkins Hashing function:
        /// https://en.wikipedia.org/wiki/Jenkins_hash_function
        /// </summary>
        /// <returns></returns>
        public uint Hash()
        {
            uint hash = 0;
            if( Value != null ) {
                foreach( char c in Value ) {
                    hash += char.ToUpper(c);
                    hash += hash << 10;
                    hash ^= hash >>  6;
                }
                hash += hash <<  3;
                hash ^= hash >> 11;
                hash += hash << 15;
            }
            return hash;
        }

        public HashedString(string str) {
            Value = str;
        }

        public HashedString() { }

        public static implicit operator HashedString ( string str ) => new HashedString { Value = str };
        public static implicit operator string ( HashedString str ) => str.Value;
    }
}
