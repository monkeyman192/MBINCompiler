using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace libMBIN {

    internal static class BinaryStreamExtensions {

        public static void Align( this BinaryReader reader, int alignBy, long templateStartOffset ) {
            long offset = reader.BaseStream.Position - templateStartOffset;
            long mod = offset % alignBy;
            if (mod != 0) reader.BaseStream.Position += (alignBy - mod);
        }

        public static void Align( this BinaryWriter writer, int alignBy, long templateStartOffset ) {
            long offset = writer.BaseStream.Position - templateStartOffset;
            long mod = offset % alignBy;
            if (mod != 0) writer.Write( new byte[alignBy - mod] ); // :)
        }

        public static string ReadString( this BinaryReader reader, Encoding encoding, int size, bool nullTerminated = false ) {
            byte[] stringData = reader.ReadBytes( size );
            string stringValue = encoding.GetString( stringData );
            if (nullTerminated) {
                int nullIndex = stringValue.IndexOf( "\0", StringComparison.Ordinal );
                if (nullIndex >= 0) {
                    stringValue = stringValue.Remove( nullIndex );
                }
            }

            return stringValue;
        }

        public static void WriteString( this BinaryWriter writer, string str, Encoding encoding = null, int? size = null, bool nullTerminated = false ) {
            encoding = encoding ?? Encoding.ASCII;
            str = str ?? String.Empty;

            int bufferSize = encoding.GetBytes( str ).Length;
            if (size != null) bufferSize = size.Value;

            int encodingSize = encoding.GetMaxByteCount( 1 );

            if (nullTerminated && size == null) bufferSize += 1; // add space for null terminator

            byte[] stringBytes = encoding.GetBytes( str );
            Array.Resize( ref stringBytes, bufferSize );

            if (nullTerminated && bufferSize > 0) {
                var trimmedStringBytes = encoding.GetBytes( encoding.GetString( stringBytes ) );
                if ( trimmedStringBytes.Length > stringBytes.Length ) {
                    trimmedStringBytes = stringBytes; // .NET failed to reencode the trimmed string properly?
                }

                int nullOffset = trimmedStringBytes.Length;
                if ( nullOffset == bufferSize )
                    nullOffset -= 1;

                stringBytes[nullOffset] = 0; // atm this might add a null in the middle of a character!
            }

            writer.Write( stringBytes );
        }

        // Thank you to HugoPeters for the methods below:
        // https://github.com/HugoPeters/NMS-Tools/blob/master/NMS-View/Source/NMSView/NMSView.Windows/HalfHelper.cs
        public static float ReadHalfLittle(this BinaryReader binaryReader)
        {
            UInt16 u = binaryReader.ReadUInt16();
            int sign = (u >> 15) & 0x00000001;
            int exp = (u >> 10) & 0x0000001F;
            int mant = u & 0x000003FF;

            exp = exp + (127 - 15);

            int i = (sign << 31) | (exp << 23) | (mant << 13);
            byte[] buff = BitConverter.GetBytes(i);

            return BitConverter.ToSingle(buff, 0);
        }

        public static ushort HalfLittleToUInt16(float value)
        {
            byte[] buff = BitConverter.GetBytes(value);
            int i = BitConverter.ToInt32(buff, 0);
            int sign = i >> 31;
            int exp = (i >> 23) & 0xFF;
            int mant = (i >> 13) & 0x7FF;

            exp = exp - (127 - 15);

            UInt16 ret = (ushort)((sign << 15) | (exp << 10) | mant);
            return ret;
        }

        public static float ToFloat(UInt16 u)
        {
            // UInt16 u = binaryReader.ReadUInt16();
            int sign = (u >> 15) & 0x00000001;
            int exp = (u >> 10) & 0x0000001F;
            int mant = u & 0x000003FF;

            exp = exp + (127 - 15);

            int i = (sign << 31) | (exp << 23) | (mant << 13);
            byte[] buff = BitConverter.GetBytes(i);

            return BitConverter.ToSingle(buff, 0);
        }

        public static UInt16 ToHalf(this float f)
        {
            byte[] bytes = BitConverter.GetBytes((double)f);
            ulong bits = BitConverter.ToUInt64(bytes, 0);
            ulong exponent = bits & 0x7ff0000000000000L;
            ulong mantissa = bits & 0x000fffffffffffffL;
            ulong sign = bits & 0x8000000000000000L;
            int placement = (int)((exponent >> 52) - 1023);
            if (placement > 15 || placement < -14)
                return ToHalf(-1.0f);

            UInt16 exponentBits = (UInt16)((15 + placement) << 10);
            UInt16 mantissaBits = (UInt16)(mantissa >> 42);
            UInt16 signBits = (UInt16)(sign >> 48);
            return (UInt16)(exponentBits | mantissaBits | signBits);
        }

    }

}
