//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace GuncelYazılımCase.Module.BusinessObjects.Database
{

    public partial class DboCaseType : XPObject
    {
        string fType;
        public string Type
        {
            get { return fType; }
            set { SetPropertyValue<string>(nameof(Type), ref fType, value); }
        }
        [Association(@"DboCasesReferencesDboCaseType")]
        public XPCollection<DboCases> DboCasesCollection { get { return GetCollection<DboCases>(nameof(DboCasesCollection)); } }
    }

}
