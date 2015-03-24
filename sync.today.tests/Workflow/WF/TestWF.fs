module TestWF

open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open Common

[<TestFixture>] 
type ``running XAML workflow`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
        logger.Info("Test")

    [<Test>] 
    member x.``when run simple XAML workflow`` ()=
        let basicWF = """<Activity mc:Ignorable="sap sap2010 sads" x:Class="WorkflowConsoleApplication1.Workflow1" sap2010:ExpressionActivityEditor.ExpressionActivityEditor="C#" sap2010:WorkflowViewState.IdRef="WorkflowConsoleApplication1.Workflow1_1"
 xmlns="http://schemas.microsoft.com/netfx/2009/xaml/activities"
 xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
 xmlns:sads="http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger"
 xmlns:sap="http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation"
 xmlns:sap2010="http://schemas.microsoft.com/netfx/2010/xaml/activities/presentation"
 xmlns:scg="clr-namespace:System.Collections.Generic;assembly=mscorlib"
 xmlns:sco="clr-namespace:System.Collections.ObjectModel;assembly=mscorlib"
 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
  <TextExpression.NamespacesForImplementation>
    <sco:Collection x:TypeArguments="x:String">
      <x:String>System</x:String>
      <x:String>System.Collections.Generic</x:String>
      <x:String>System.Data</x:String>
      <x:String>System.Linq</x:String>
      <x:String>System.Text</x:String>
    </sco:Collection>
  </TextExpression.NamespacesForImplementation>
  <TextExpression.ReferencesForImplementation>
    <sco:Collection x:TypeArguments="AssemblyReference">
      <AssemblyReference>Microsoft.CSharp</AssemblyReference>
      <AssemblyReference>System</AssemblyReference>
      <AssemblyReference>System.Activities</AssemblyReference>
      <AssemblyReference>System.Core</AssemblyReference>
      <AssemblyReference>System.Data</AssemblyReference>
      <AssemblyReference>System.Runtime.Serialization</AssemblyReference>
      <AssemblyReference>System.ServiceModel</AssemblyReference>
      <AssemblyReference>System.ServiceModel.Activities</AssemblyReference>
      <AssemblyReference>System.Xaml</AssemblyReference>
      <AssemblyReference>System.Xml</AssemblyReference>
      <AssemblyReference>System.Xml.Linq</AssemblyReference>
      <AssemblyReference>mscorlib</AssemblyReference>
      <AssemblyReference>WorkflowConsoleApplication1</AssemblyReference>
    </sco:Collection>
  </TextExpression.ReferencesForImplementation>
  <Sequence sap2010:WorkflowViewState.IdRef="Sequence_1">
    <WriteLine sap2010:WorkflowViewState.IdRef="WriteLine_1" Text="Start" />
    <WriteLine sap2010:WorkflowViewState.IdRef="WriteLine_2" Text="End" />
    <sads:DebugSymbol.Symbol>d05EOlx0ZW1wXFdvcmtmbG93Q29uc29sZUFwcGxpY2F0aW9uMVxXb3JrZmxvd0NvbnNvbGVBcHBsaWNhdGlvbjFcV29ya2Zsb3cxLnhhbWwFJAMoDgIBASUFJU0CAQQmBSZLAgECJUMlSgIBBSZDJkgCAQM=</sads:DebugSymbol.Symbol>
  </Sequence>
  <sap2010:WorkflowViewState.ViewStateManager>
    <sap2010:ViewStateManager>
      <sap2010:ViewStateData Id="WriteLine_1" sap:VirtualizedContainerService.HintSize="211,62" />
      <sap2010:ViewStateData Id="WriteLine_2" sap:VirtualizedContainerService.HintSize="211,62" />
      <sap2010:ViewStateData Id="Sequence_1" sap:VirtualizedContainerService.HintSize="233,288">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments="x:String, x:Object">
            <x:Boolean x:Key="IsExpanded">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id="WorkflowConsoleApplication1.Workflow1_1" sap:VirtualizedContainerService.HintSize="273,368" />
    </sap2010:ViewStateManager>
  </sap2010:WorkflowViewState.ViewStateManager>
</Activity>"""
        WorkflowRunner.runString(basicWF)
