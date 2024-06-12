using Microsoft.JSInterop;
using Newtonsoft.Json;
using SampleWebsiteBlazorWasm.Shared.Models;
using System;
using System.Threading.Tasks;

namespace SampleWebsiteBlazorWasm.Client
{
    public class JsInteropCallbacks
    {
        private static DocumentGenerationService _documentService;

        public static void Initialize(DocumentGenerationService documentService)
        {
            _documentService = documentService;
        }

        [JSInvokable]
        public static Task SaveDocument(string response)
        {
            var acquireResponse = JsonConvert.DeserializeObject<AcquireResponseModel>(response);

            var acquireEvent = new AcquireEventModel
            {
                IsUpload = false
            };

            if (!acquireResponse.IsError)
            {
                acquireEvent.AcquireResponse = acquireResponse.ResponseText;
            }
            else
            {
                acquireEvent.AcquireError = acquireResponse.ResponseText;
            }

            _documentService?.NotifyDocumentGenerated(acquireEvent);
            return Task.CompletedTask;
        }

        [JSInvokable]
        public static Task UploadDocument(string response)
        {
            var acquireResponse = JsonConvert.DeserializeObject<AcquireResponseModel>(response);

            var acquireEvent = new AcquireEventModel
            {
                IsUpload = true
            };

            if (!acquireResponse.IsError)
            {
                acquireEvent.AcquireResponse = acquireResponse.ResponseText;
            }
            else
            {
                acquireEvent.AcquireError = acquireResponse.ResponseText;
            }

            _documentService?.NotifyDocumentGenerated(acquireEvent);
            return Task.CompletedTask;
        }
    }
}
