using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class TwainOptionsModel
    {
        public ScannerInterfaceModel ScannerInterface { get; set; }
        public OcrTypeModel OcrType { get; set; }
        public PagePlacementModel PagePlacement { get; set; }
        public OutputFileTypeModel OutputFileType { get; set; }
    }
}
