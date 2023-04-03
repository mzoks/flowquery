using System;
using System.Reflection;
using System.Security;

[assembly: AssemblyDescription("An extension for NHibernate that provides a better flow when, and a safer way of, " +
    "querying over NHibernate's ICriteria API.")]
[assembly: AssemblyCompany("Niklas Källander, LL")]
[assembly: AssemblyCopyright("Copyright © Niklas Källander, Zoran Malinovic 2010 - 2023")]
[assembly: AssemblyProduct("FlowQueryNHibernate")]
[assembly: AssemblyTitle("FlowQueryNHibernate")]

[assembly: AssemblyVersion("3.1.*")]
[assembly: AssemblyFileVersion("3.1.0")]
[assembly: AssemblyInformationalVersion("3.1.0-preview-2")]

[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(true)]