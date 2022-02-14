# Knowledgeone WebTWAIN Blazor Sample
The Knowledgeone WebTWAIN SDK product provides a webservice interface for interacting with a TWAIN compatible scanner. For more information, please visit [https://webtwainsdk.com/](https://webtwainsdk.com/).

To run the demo either visit [https://webtwainsdk.com/demo-request/](https://webtwainsdk.com/demo-request/) or clone this repository and build the application locally.

If you have cloned the repository, you will need to visit [https://webtwainsdk.com/demo-request/](https://webtwainsdk.com/demo-request/) to download and install the required service. Services are available for Windows and MacOS.

Samples are also available for .NET Core, React, Angular & VueJS. Please see [https://github.com/Knowledgeone-Corporation/](https://github.com/Knowledgeone-Corporation/).

## Getting started.
### Prerequisites
* Visual Studio
* .NET Core 3.1 Runtime (required for the demo "backend" to receive the response from the service)
* .NET Framework 4.7.2 if running on Windows (required for the scanning service)

### Usage

Using Visual Studio, set the startup project to **SampleWebsiteBlazorWasm.Server** and press F5 or click the run button. This will launch both the WASM app and the Web-API

### Further Documentation

#### Provided Component
To use the provided component please refer to the [component documentation](https://github.com/Knowledgeone-Corporation/web-twain-sample/blob/master/docs/reference/component.md).

#### API Reference
To consume the REST API please refer to the [API documentation](https://github.com/Knowledgeone-Corporation/web-twain-sample/blob/master/docs/reference/service.md)

## Licence
The demonstration services have the following limitations:
- generated documents contain a watermark
- multi-page documents are limited to 10 pages
- OCR is limited to the first page of the document.
 
These limitations are not present in the licensed product. 

To purchase a licence please [contact us](https://webtwainsdk.com/contact-us/).
