using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libMBIN
{
    // ReSharper disable once InconsistentNaming
    public class IO : IDisposable
    {
        #region Public Fields

        public BinaryReader Reader;
        public BinaryWriter Writer;
        public Stream Stream;

        #endregion

        #region Constructors

        public IO(string filePath)
        {
            Stream = new FileStream(filePath, FileMode.Open);
            InitIo();
        }

        public IO(string filePath, FileMode mode)
        {
            Stream = new FileStream(filePath, mode);
            InitIo();
        }

        public IO(Stream baseStream)
        {
            Stream = baseStream;
            InitIo();
        }

        public void Dispose()
        {
            Stream.Dispose();
            Reader.Dispose();
            Writer.Dispose();
        }

        #endregion

        #region Public

        public bool AddBytes(long numBytes)
        {
            const int blockSize = 0x1000;

            long startPos = Stream.Position;
            long startSize = Stream.Length;
            long endPos = startPos + numBytes;
            long endSize = Stream.Length + numBytes;

            Stream.SetLength(endSize);

            long totalWrite = startSize - startPos;

            while (totalWrite > 0)
            {
                int toRead = totalWrite < blockSize ? (int)totalWrite : blockSize;

                Stream.Position = startPos + (totalWrite - toRead);
                var data = Reader.ReadBytes(toRead);

                Stream.Position = startPos + (totalWrite - toRead);
                var blankData = new byte[toRead];
                Writer.Write(blankData);

                Stream.Position = endPos + (totalWrite - toRead);
                Writer.Write(data);

                totalWrite -= toRead;
            }

            Stream.Position = startPos;

            return true;
        }

        public bool DeleteBytes(long numBytes)
        {
            if (Stream.Position + numBytes > Stream.Length)
                return false;

            const int blockSize = 0x1000;

            long startPos = Stream.Position;
            long endPos = startPos + numBytes;
            long endSize = Stream.Length - numBytes;
            long i = 0;

            while (i < endSize)
            {
                long totalRemaining = endSize - i;
                int toRead = totalRemaining < blockSize ? (int)totalRemaining : blockSize;

                Stream.Position = endPos + i;
                byte[] data = Reader.ReadBytes(toRead);

                Stream.Position = startPos + i;
                Writer.Write(data);

                i += toRead;
            }

            Stream.SetLength(endSize);
            return true;
        }

        #endregion

        #region Private

        private void InitIo()
        {
            Reader = new BinaryReader(Stream, Encoding.ASCII);
            Writer = Stream.CanWrite ? new BinaryWriter(Stream) : null;
        }

        #endregion
    }
}
