Namespace CustomRepositoryItem
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.CanGrow = False
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.StyleName = "FieldCaption"
            Me.xrTableCell11.Text = "Time"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell11.Weight = 154R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.CanGrow = False
            Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Time")})
            Me.xrTableCell12.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.StyleName = "DataField"
            Me.xrTableCell12.StylePriority.UseFont = False
            Me.xrTableCell12.Text = "xrTableCell12"
            Me.xrTableCell12.Weight = 272.03851596160371R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.CanGrow = False
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StyleName = "FieldCaption"
            Me.xrTableCell7.Text = "Seller"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell7.Weight = 178R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.CanGrow = False
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StyleName = "FieldCaption"
            Me.xrTableCell9.Text = "Customer"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell9.Weight = 304R
            ' 
            ' pageFooterBand1
            ' 
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.HeightF = 29F
            Me.pageFooterBand1.Name = "pageFooterBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell8, Me.xrTableCell13, Me.xrTableCell10, Me.xrTableCell14, Me.xrTableCell12})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 1R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.CanGrow = False
            Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Seller.FirstName")})
            Me.xrTableCell8.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StyleName = "DataField"
            Me.xrTableCell8.StylePriority.UseFont = False
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 75.3738823720283R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.CanGrow = False
            Me.xrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Seller.LastName")})
            Me.xrTableCell13.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.StylePriority.UseFont = False
            Me.xrTableCell13.Text = "xrTableCell13"
            Me.xrTableCell13.Weight = 237.03509645518008R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.CanGrow = False
            Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customer.FirstName")})
            Me.xrTableCell10.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.StyleName = "DataField"
            Me.xrTableCell10.StylePriority.UseFont = False
            Me.xrTableCell10.Text = "xrTableCell10"
            Me.xrTableCell10.Weight = 76.0171231045875R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.CanGrow = False
            Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customer.LastName")})
            Me.xrTableCell14.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.StylePriority.UseFont = False
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.Weight = 457.53538210660037R
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(637F, 36F)
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell9, Me.xrTableCell11})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 1R
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(5.999997F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow4})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(637.9999F, 23.00001F)
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Black
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Teal
            Me.Title.Name = "Title"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 23.00001F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.reportHeaderBand1.HeightF = 61F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(638F, 43F)
            Me.xrLabel1.StyleName = "Title"
            Me.xrLabel1.Text = "Report1"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Arial", 9F)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Arial", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' pageHeaderBand1
            ' 
            Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.pageHeaderBand1.HeightF = 42F
            Me.pageHeaderBand1.Name = "pageHeaderBand1"
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.DataMember = "GetAll"
            Me.objectDataSource1.DataSource = GetType(CustomRepositoryItem.Data.History)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageHeaderBand1, Me.pageFooterBand1, Me.reportHeaderBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "15.1"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

    End Class
End Namespace
