using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using libMBIN.Models;

namespace libMBIN
{
    public class MBINFile : IDisposable
    {

        public MBINHeader Header; // TODO: header instead of Header
        private readonly IO _io;
        private readonly string _filePath;
        private readonly bool _keepOpen;
        public ulong FileLength = 0; // TODO: fileLength instead of FileLength

        public static bool IsValid(string path)
        {
            if (!File.Exists(path)) return false;
            using (var mbin = new MBINFile(path)) {
                return mbin.Load() ? mbin.Header.IsValid : false;
            }
        }

        public MBINFile(string path)
        {
            _filePath = path;
            _io = new IO(path, FileMode.OpenOrCreate);
            _keepOpen = false;
        }

        public MBINFile(Stream stream, bool keepOpen = false)
        {
            _filePath = "/DEV/NULL";
            _io = new IO(stream);
            _keepOpen = keepOpen;
        }

        public bool Load()
        {
            if (_io.Stream.Length < 0x60) return false;
            _io.Stream.Position = 0;
            Header = (MBINHeader)NMSTemplate.DeserializeBinaryTemplate(_io.Reader, "MBINHeader");
            return true;
        }

        public bool Save()
        {
            _io.Stream.Position = 0;
            _io.Writer.Write(Header.SerializeBytes());
            _io.Writer.Flush();

            return true;
        }

        public NMSTemplate GetData()
        {
            _io.Stream.Position = 0x60;
            return NMSTemplate.DeserializeBinaryTemplate(_io.Reader, Header.GetXMLTemplateName());
        }

        public void SetData(NMSTemplate template)
        {
            _io.Stream.SetLength(0x60);
            _io.Stream.Position = 0x60;

            byte[] data = template.SerializeBytes();
            _io.Writer.Write(data);

            FileLength = (ulong)data.LongLength;

            Header.TemplateName = "c" + template.GetType().Name;
        }

        public void Dispose()
        {
            if (_io != null && _keepOpen == false) _io.Dispose();
        }
    }
}
