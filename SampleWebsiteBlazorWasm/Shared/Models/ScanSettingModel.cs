namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class ScanSettingModel
    {
        public ScannerDetails ScannerDetails { get; set; }
        public bool UseOCR { get; set; }
        public int OCRType { get; set; }
        public string ScanType { get; set; }
        public int FileCompressionType { get; set; }
    }

    public class ScannerDetails
    {
        public string ScanSource { get; set; }
        public string DocumentSource { get; set; }
        public string Resolution { get; set; }
        public string Color { get; set; }
        public string PageSize { get; set; }
        public string Duplex { get; set; }
    }
}
