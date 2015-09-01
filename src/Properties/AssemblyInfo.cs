﻿using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Nest.Indexify")]
[assembly: AssemblyDescription("Helper library for Elasticsearch index creation using a contributor model")]
[assembly: AssemblyCompany("Storm ID Ltd")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
    [assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyProduct("Nest.Queryify")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: ComVisible(false)]
