Imports System
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports DevExpress.DataAccess.UI.Wizard.Services
Imports DevExpress.XtraReports.UI
' ...

Namespace CustomRepositoryItem
    Partial Public Class fmDesigner
        Inherits Form

        Private ReadOnly myRepositoryItemsProvider As MyRepositoryItemsProvider

        Public Sub New()
            InitializeComponent()
            myRepositoryItemsProvider = New MyRepositoryItemsProvider()
            ReplaceService(reportDesignerMDIController, GetType(IRepositoryItemsProvider), myRepositoryItemsProvider)
            AddHandler reportDesignerMDIController.DesignPanelLoaded, AddressOf reportDesignerMDIController_DesignPanelLoaded
        End Sub

        Private Sub reportDesignerMDIController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs)
            ReplaceService(e.DesignerHost, GetType(IRepositoryItemsProvider), myRepositoryItemsProvider)
        End Sub

        Private Sub ReplaceService(ByVal container As IServiceContainer, ByVal serviceType As Type, ByVal serviceInstance As Object)
            If container.GetService(serviceType) IsNot Nothing Then
                container.RemoveService(serviceType)
            End If
            container.AddService(serviceType, serviceInstance)
        End Sub

        Private Sub fmDesigner_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim report As XtraReport = New XtraReport1()
            reportDesignerMDIController.OpenReport(report)
        End Sub
    End Class
End Namespace
