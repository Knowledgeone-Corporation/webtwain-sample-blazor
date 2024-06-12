using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public class DeviceModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, DeviceUnitModel> DocumentSourceIds { get; set; } = new Dictionary<string, DeviceUnitModel>();
    }

    public class DeviceUnitModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Dictionary<string, string> ResolutionIds { get; set; }
        public Dictionary<string, string> PixelTypeIds { get; set; }
        public Dictionary<string, string> PageSizeIds { get; set; }
        public Dictionary<string, string> DuplexIds { get; set; }
    }
}
