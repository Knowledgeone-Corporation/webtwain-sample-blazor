﻿using System.Collections.Generic;

namespace SampleWebsiteBlazorWasm.Shared.Models
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
