using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class OutputFileTypeModel
    {
        public string PDF { get; } = "PDF";
        public string PDF_A { get; } = "PDF/A";
        public string TIFF { get; } = "TIFF";
        public string JPEG { get; } = "JPG";
        public string GIF { get; } = "GIF";
        public string BMP { get; } = "BMP";
        public string PNG { get; } = "PNG";

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
