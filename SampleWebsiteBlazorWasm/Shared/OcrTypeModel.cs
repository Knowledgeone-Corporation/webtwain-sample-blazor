using System;
using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class OcrTypeModel
    {
        public int None { get; set; }
        public int Mapped { get; set; }
        public int Embedded { get; set; }

        public Dictionary<string, string> OcrTypes => new Dictionary<string, string>() {
            {nameof(None),None.ToString() },
            {nameof(Mapped),Mapped.ToString() },
            {nameof(Embedded),Embedded.ToString()}
        };
    }
}
