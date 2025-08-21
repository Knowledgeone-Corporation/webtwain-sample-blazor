using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class FileCompressionTypeModel
    {
        public int None { get; } = 0;
        public int Low { get; } = 1;
        public int Medium { get; } = 2;
        public int High { get; } = 3;

        public Dictionary<string, int> FileCompressionTypes => new Dictionary<string, int>()
        {
            { nameof(None), None },
            { nameof(Low), Low },
            { nameof(Medium), Medium },
            { nameof(High), High }
        };
    }
}
