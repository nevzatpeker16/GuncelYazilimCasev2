using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.CodeParser;
using DevExpress.Utils.Extensions;
using GuncelYazılımCase.Module.BusinessObjects.Database;

namespace GuncelYazılımCase.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CasesStatusController : ViewController
    {
        public CasesStatusController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
        private void CasesStatusController_Activated(object sender, EventArgs e)
        {
            // Enables the ClearTasks Action if the current Detail View's ViewEditMode property
            // is set to ViewEditMode.Edit.
            UpdateStatus.Enabled.SetItemValue("EditMode",
                ((DetailView)View).ViewEditMode == ViewEditMode.Edit);
            ((DetailView)View).ViewEditModeChanged +=
                new EventHandler<EventArgs>(CasesStatusCleared_ViewEditModeChanged);
        }
        // Manages the ClearTasks Action enabled state.
        void CasesStatusCleared_ViewEditModeChanged(object sender, EventArgs e)
        {
            UpdateStatus.Enabled.SetItemValue("EditMode",
                ((DetailView)View).ViewEditMode == ViewEditMode.Edit);
        }


        private void UpdateStatus_Execute(Object sender, SimpleActionExecuteEventArgs e)
        {
            while (((DboCases)View.CurrentObject).Status.Statu == "Closed")
            {
                 
            }
            ObjectSpace.SetModified(View.CurrentObject);
        }

    }
}
