<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/SinglePageReport/Data.cs) (VB: [Data.vb](./VB/SinglePageReport/Data.vb))
* [Form1.cs](./CS/SinglePageReport/Form1.cs) (VB: [Form1.vb](./VB/SinglePageReport/Form1.vb))
* **[SinglePageHelper.cs](./CS/SinglePageReport/SinglePageHelper.cs) (VB: [SinglePageHelper.vb](./VB/SinglePageReport/SinglePageHelper.vb))**
<!-- default file list end -->
# How to create a single-page report to print a document on roll paper


<p>With the 14.2 release, it has become possible to optimize a report for printing on roll paper by setting a single <a href="https://www.devexpress.com/Support/Center/Question/Details/S50061">RollPaper</a> property.<br /><br /><strong>For versions released prior to v14.2:</strong><br />This example demonstrates how to calculate the resulting report height and change its page size to place the report content into a single page. To accomplish this, create a document using the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_CreateDocumenttopic161">XtraReport.CreateDocument method</a>, change the document page settings so the document contains a single page, and then adjust the page height by calculating the total height. The first adjustment is required to remove redundant Page headers and footers to calculate the resulting height more precisely.</p>

<br/>


