<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599655/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T110534)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/SinglePageReport/Data.cs) (VB: [Data.vb](./VB/SinglePageReport/Data.vb))
* [Form1.cs](./CS/SinglePageReport/Form1.cs) (VB: [Form1.vb](./VB/SinglePageReport/Form1.vb))
* **[SinglePageHelper.cs](./CS/SinglePageReport/SinglePageHelper.cs) (VB: [SinglePageHelper.vb](./VB/SinglePageReport/SinglePageHelper.vb))**
<!-- default file list end -->
# How to create a single-page report to print a document on roll paper


<p>With the 14.2 release, it has become possible to optimize a report for printing on roll paper by setting a single <a href="https://www.devexpress.com/Support/Center/Question/Details/S50061">RollPaper</a> property.<br /><br /><strong>For versions released prior to v14.2:</strong><br />This example demonstrates how to calculate the resulting report height and change its page size to place the report content into a single page. To accomplish this, create a document using the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_CreateDocumenttopic161">XtraReport.CreateDocument method</a>, change the document page settings so the document contains a single page, and then adjust the page height by calculating the total height. The first adjustment is required to remove redundant Page headers and footers to calculate the resulting height more precisely.</p>

<br/>


