using System;
namespace SampleWebsiteBlazorWasm.Shared.Models
{
    public sealed class MappedOption<T>
    {
        public string Display { get; set; }
        public T Value { get; set; }
    }
}
