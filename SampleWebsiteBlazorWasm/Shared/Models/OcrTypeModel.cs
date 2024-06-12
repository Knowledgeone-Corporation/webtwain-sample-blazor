using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class OcrTypeModel
    {
        public int None { get; } = 0;
        public int Mapped { get; } = 1;
        public int Embedded { get; } = 2;

        public Dictionary<string, int> OcrTypes => new Dictionary<string, int>() {
            {nameof(None), None},
            {nameof(Mapped), Mapped },
            {nameof(Embedded), Embedded }
        };
    }
}
