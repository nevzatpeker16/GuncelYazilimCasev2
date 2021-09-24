using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace GuncelYazılımCase.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    public partial class DboEmployee
    {
        public DboEmployee(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
