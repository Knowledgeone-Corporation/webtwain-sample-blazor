using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class OcrTypeModel
    {
        public int None { get; set; }
        public int Mapped { get; set; }
        public int Embedded { get; set; }

        public Dictionary<string, int> OcrTypes => new Dictionary<string, int>() {
            {nameof(None),None },
            {nameof(Mapped),Mapped },
            {nameof(Embedded),Embedded}
        };
    }
}
