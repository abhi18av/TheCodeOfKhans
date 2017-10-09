//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Management.Automation;
using System.Reflection;

namespace System.Management.Automation.Runspaces
{
    internal sealed class GetEvent_Types_Ps1Xml
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        static MethodInfo GetMethodInfo(string typeName, string method)
        {
            var type = LanguagePrimitives.ConvertTo<Type>(typeName);
            return GetMethodInfo(type, method);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        static MethodInfo GetMethodInfo(Type type, string method)
        {
            return type.GetMethod(method, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
        }

        static ScriptBlock GetScriptBlock(string s)
        {
            var sb = ScriptBlock.CreateDelayParsedScriptBlock(s, isProductCode: true);
            sb.LanguageMode = PSLanguageMode.FullLanguage;
            return sb;
        }

        public static IEnumerable<TypeData> Get()
        {

            var td1 = new TypeData(@"System.Diagnostics.Eventing.Reader.EventLogConfiguration", true);
            td1.DefaultDisplayPropertySet =
                new PropertySetData(new [] { "LogName", "MaximumSizeInBytes", "RecordCount", "LogMode" }) { Name = "DefaultDisplayPropertySet" };
            yield return td1;

            var td2 = new TypeData(@"System.Diagnostics.Eventing.Reader.EventLogRecord", true);
            td2.DefaultDisplayPropertySet =
                new PropertySetData(new [] { "TimeCreated", "ProviderName", "Id", "Message" }) { Name = "DefaultDisplayPropertySet" };
            yield return td2;

            var td3 = new TypeData(@"System.Diagnostics.Eventing.Reader.ProviderMetadata", true);
            td3.Members.Add("ProviderName",
                new AliasPropertyData("ProviderName", "Name"));
            td3.DefaultDisplayPropertySet =
                new PropertySetData(new [] { "Name", "LogLinks" }) { Name = "DefaultDisplayPropertySet" };
            yield return td3;

#if !CORECLR
            var td4 = new TypeData(@"Microsoft.PowerShell.Commands.GetCounter.CounterSet", true);
            td4.Members.Add("Counter",
                new AliasPropertyData("Counter", "Paths"));
            yield return td4;

            var td5 = new TypeData(@"Microsoft.PowerShell.Commands.GetCounter.PerformanceCounterSample", true);
            td5.DefaultDisplayPropertySet =
                new PropertySetData(new [] { "Path", "InstanceName", "CookedValue" }) { Name = "DefaultDisplayPropertySet" };
            yield return td5;

            var td6 = new TypeData(@"Microsoft.PowerShell.Commands.GetCounter.PerformanceCounterSampleSet", true);
            td6.DefaultDisplayPropertySet =
                new PropertySetData(new [] { "Timestamp", "Readings" }) { Name = "DefaultDisplayPropertySet" };
            yield return td6;

            var td7 = new TypeData(@"Microsoft.PowerShell.Commands.GetCounter.PerformanceCounterSampleSet", true);
            td7.Members.Add("Readings",
                new ScriptPropertyData(@"Readings", GetScriptBlock(@"$strPaths = """"
          foreach ($ctr in $this.CounterSamples)
          {
              $strPaths += ($ctr.Path + "" :"" + ""`n"")
              $strPaths += ($ctr.CookedValue.ToString() + ""`n`n"")
          }
          return $strPaths"), null));
            yield return td7;
#endif
        }
    }
}
