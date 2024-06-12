namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class ScanSettingModel
    {
        public string ScanSource { get; set; }
        public bool UseOCR { get; set; }
        public int OCRType { get; set; }
        public string ScanType { get; set; }
    }
}
