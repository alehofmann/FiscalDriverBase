using System.Reflection;
//using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DCS.FiscalDriverBase")]
[assembly: AssemblyDescription("Fiscal Driver Standard Interface")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Alex Hofmann")]
[assembly: AssemblyProduct("DCS.FiscalDriverBase")]
[assembly: AssemblyCopyright("Copyright © Alex Hofmann 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the Id of the typelib if this project is exposed to COM
[assembly: Guid("dff9b192-84e9-4659-96ce-0b68707e18bb")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.2.0")]
[assembly: AssemblyFileVersion("1.0.2.0")]
/*
 * 1.0.0.0 20190211: Initial version.
 * 1.0.0.1 20190301: Added: bool PrintTransaction(TransactionDTO transaction, ref int invoiceNumber, bool dummyParam = true);
 * 1.0.0.2 20190314: (AleH) Some casing corrections to satisfy standards
 * 1.0.1.0 20190315: (AleH) Overload de OpenTransaction que no usa VBA.Collections
 * 1.0.1.1 20190321: (AleH) iFiscalDriverBase interop 
 * 1.0.1.2 20190325: (AleH) Bug en TransactionDto -> New Product
 * 1.0.1.3 20190326: (AleH) ComVisible=False en OpenTransaction y PrintTransaction
 * 1.0.2.0 20190408: (AleH) Se elimina referencia DCSPosUtils
 */
