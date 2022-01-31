using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class ScannerInterfaceModel
    {
        public int Hidden { get; set; }
        public int Visible { get; set; }
        public int Web { get; set; }
        public int Desktop { get; set; }

        public Dictionary<string, int> ScannerInterfaces => new Dictionary<string, int>() {
            {nameof(Hidden),Hidden },
            {nameof(Visible),Visible },
            {nameof(Web),Web},
            {nameof(Desktop),Desktop},
        };
    }
}
