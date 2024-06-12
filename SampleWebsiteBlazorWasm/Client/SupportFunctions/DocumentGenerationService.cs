using System;
using SampleWebsiteBlazorWasm.Shared.Models;

namespace SampleWebsiteBlazorWasm.Client
{
    public class DocumentGenerationService
    {
        public event Action<AcquireEventModel> OnDocumentGenerated;

        public void NotifyDocumentGenerated(AcquireEventModel acquireEvent)
        {
            OnDocumentGenerated?.Invoke(acquireEvent);
        }
    }
}
