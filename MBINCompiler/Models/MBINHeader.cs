using System;
using System.Reflection;

namespace MBINCompiler.Models
{
    public class MBINHeader : NMSTemplate
    {
        public uint Magic; // can be 0xCCCCCCCC, or 0xDDDDDDDD for MBIN.PC files, probably used to seperate PC files from PS4
        public int Version; // seems to be a version field, game checks this under certain conditions to make sure it's equal to 2500
        //public long BuildDateTime; // 0x0 for most files, 0xFFFF.. for TkGeometryData files, timestamp eg. 201607201542 (decimal) on global files and older MBINs, likely removed the code that set it at some stage
        //public long TemplateGUID; // seems to be unique across templates (files using the same template share the same GUID)
        [NMS(Size = 0x10)]
        public string Tag;

        [NMS(Size = 0x40)]
        public string TemplateName;

        public ulong Padding58; // doesn't seem to be used in the game, stores 00.../FE... in the games files

        public string GetXMLTemplateName()
        {
            if (!TemplateName.StartsWith("c") || TemplateName.Length < 2)
                return TemplateName;

            return TemplateName.Substring(1); // remove the "c" (compiled?) from the start of the template name
        }

        public void SetDefaults()
        {
            Magic = 0xCCCCCCCC;
            Version = 2500;
            
            // these two values aren't checked, so we can set them to whatever we like
            //BuildDateTime = 0x706D6F434E49424D;
            //TemplateGUID = 0x302E3172656C69;
            string ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Tag = String.Format("MBINCver{0}", ver.Substring(0, ver.Length - 2));

            TemplateName = string.Empty;
            Padding58 = ulong.Parse($"{DateTime.Now:yyyyMMddhhmm}"); // may as well make use of this field too
        }
    }
}
