
namespace GuncelYazılımCase.Module.Controllers
{
    partial class CasesStatusController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpdateStatus = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // UpdateStatus
            // 
            this.UpdateStatus.Caption = "Çağrı değişikliği";
            this.UpdateStatus.ConfirmationMessage = "Çağrı statüsünü değiştirmek istiyor musunuz ? ";
            this.UpdateStatus.Id = "UpdateStatus";
            this.UpdateStatus.ImageName = "Activation_Clear";
            this.UpdateStatus.TargetObjectType = typeof(GuncelYazılımCase.Module.BusinessObjects.Database.DboStatus);
            this.UpdateStatus.TargetViewId = "Cases";
            this.UpdateStatus.ToolTip = null;
            this.UpdateStatus.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UpdateStatus_Execute);
            // 
            // CasesStatusController
            // 
            this.Actions.Add(this.UpdateStatus);
            this.TargetObjectType = typeof(GuncelYazılımCase.Module.BusinessObjects.Database.DboCases);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction UpdateStatus;
    }
}
