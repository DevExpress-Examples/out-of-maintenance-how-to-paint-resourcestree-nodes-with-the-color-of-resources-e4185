<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635755/12.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4185)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to paint ResourcesTree nodes with the color of resources


<p>This example illustrates how to customize <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraSchedulerUIResourcesTreetopic"><u>ResourcesTree</u></a> nodes painting so that its nodes have the same color as corresponding resources. First of all, it should be especially noted that there is no appropriate method to achieve this result when default resource color schemas are used (see <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_ResourceColorSchemastopic"><u>SchedulerControl.ResourceColorSchemas Property</u></a>) because their indexes might not correspond resource indexes (especially if a complex master-detail hierarchy of resource is used). So, you need to specify resource colors explicitely. In this example, we have mapped the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerResource_Colortopic"><u>Resource.Color Property</u></a> to the "Color" column in "Resources" table. Then, we retrieve the current resource color in the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_CustomDrawNodeCelltopic"><u>TreeList.CustomDrawNodeCell Event</u></a> and assign it to the e.Appearance.BackColor parameter of this event.</p><p>Here is a screenshot that illustrates a sample application in action:</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-paint-resourcestree-nodes-with-the-color-of-resources-e4185/12.1.6+/media/488b6b84-513c-42de-b07e-ad535aee45f0.png"></p>

<br/>


