using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class SaveToTypeModel
    {
        public int Upload { get; } = 0;
        public int Local { get; } = 1;

        public Dictionary<string, int> SaveToTypes => new Dictionary<string, int>()
        {
            {nameof(Upload), Upload },
            {nameof(Local), Local }
        };
    }
}
