using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebsiteBlazorWasm.Shared
{
    public class PagePlacementModel
    {
        public string AfterCurrentPage { get; set; }
        public string BeforeCurrentPage { get; set; }
        public string ReplaceCurrentPage { get; set; }

        public Dictionary<string, string> PagePlacements => new Dictionary<string, string>() {
            {AfterCurrentPage, nameof(AfterCurrentPage) },
            {BeforeCurrentPage, nameof(BeforeCurrentPage) },
            {ReplaceCurrentPage, nameof(ReplaceCurrentPage)}
        };
    }
}
