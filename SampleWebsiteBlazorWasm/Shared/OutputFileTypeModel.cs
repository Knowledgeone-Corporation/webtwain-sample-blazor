using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class OutputFileTypeModel
    {
        public string PDF { get; set; }
        public string PDF_A { get; set; }
        public string TIFF { get; set; }
        public string JPEG { get; set; }
        public string GIF { get; set; }
        public string BMP { get; set; }
        public string PNG { get; set; }

        public Dictionary<string, string> OutputFileTypes => new Dictionary<string, string>()
        {
            {nameof(PDF), PDF },
            {nameof(PDF_A), PDF_A },
            {nameof(TIFF), TIFF },
            {nameof(JPEG), JPEG },
            {nameof(GIF), GIF },
            {nameof(BMP), BMP },
            {nameof(PNG), PNG }
        };
    }
}
