using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class SaveToTypeModel
    {
        public int Upload { get; set; }
        public int Local { get; set; }

        public Dictionary<string, string> SaveToTypes => new Dictionary<string, string>()
        {
            {nameof(Upload), Upload.ToString() },
            {nameof(Local), Local.ToString() }
        };
    }
}
