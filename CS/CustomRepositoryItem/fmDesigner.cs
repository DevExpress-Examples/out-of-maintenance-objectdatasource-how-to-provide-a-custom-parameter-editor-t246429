using System;
using System.ComponentModel.Design;
using System.Windows.Forms;
using DevExpress.DataAccess.UI.Wizard.Services;
using DevExpress.XtraReports.UI;
// ...

namespace CustomRepositoryItem {
    public partial class fmDesigner : Form {
        readonly MyRepositoryItemsProvider myRepositoryItemsProvider;

        public fmDesigner() {
            InitializeComponent();
            myRepositoryItemsProvider = new MyRepositoryItemsProvider();
            ReplaceService(reportDesignerMDIController, typeof(IRepositoryItemsProvider), myRepositoryItemsProvider);
            reportDesignerMDIController.DesignPanelLoaded += reportDesignerMDIController_DesignPanelLoaded;
        }

        void reportDesignerMDIController_DesignPanelLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e) {
            ReplaceService(e.DesignerHost, typeof(IRepositoryItemsProvider), myRepositoryItemsProvider);
        }

        void ReplaceService(IServiceContainer container, Type serviceType, object serviceInstance) {
            if(container.GetService(serviceType) != null)
                container.RemoveService(serviceType);
            container.AddService(serviceType, serviceInstance);
        }

        void fmDesigner_Load(object sender, EventArgs e) {
            XtraReport report = new XtraReport1();
            reportDesignerMDIController.OpenReport(report);
        }
    }
}
