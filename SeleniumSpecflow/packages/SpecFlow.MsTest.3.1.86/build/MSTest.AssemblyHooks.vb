Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TechTalk.SpecFlow
Imports System
Imports System.Reflection
Imports System.CodeDom.Compiler

<GeneratedCode("SpecFlow", "3.1.86")>
<TestClass>
Public NotInheritable Class PROJECT_ROOT_NAMESPACE_MSTestAssemblyHooks
    <AssemblyInitialize>
    Public Shared Sub AssemblyInitialize(testContext As TestContext)

        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_MSTestAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunStart(currentAssembly)
    End Sub

    <AssemblyCleanup>
    Public Shared Sub AssemblyCleanup()

        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_MSTestAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunEnd(currentAssembly)
    End Sub

End Class
