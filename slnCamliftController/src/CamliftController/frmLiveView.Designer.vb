﻿Namespace CanonCamera

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmLiveView
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
            Me.tlpMain = New System.Windows.Forms.TableLayoutPanel
            Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.cboWhiteBalance = New System.Windows.Forms.ComboBox
            Me.picLiveView = New System.Windows.Forms.PictureBox
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
            Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
            Me.btnGrid = New System.Windows.Forms.Button
            Me.btnZoomOut = New System.Windows.Forms.Button
            Me.lblZoom = New System.Windows.Forms.Label
            Me.btnZoomIn = New System.Windows.Forms.Button
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
            Me.btnClose = New System.Windows.Forms.Button
            Me.TableLayoutPanel1.SuspendLayout()
            Me.tlpMain.SuspendLayout()
            Me.FlowLayoutPanel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.picLiveView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.FlowLayoutPanel3.SuspendLayout()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.tlpMain, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(577, 429)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'tlpMain
            '
            Me.tlpMain.ColumnCount = 2
            Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
            Me.tlpMain.Controls.Add(Me.FlowLayoutPanel2, 1, 0)
            Me.tlpMain.Controls.Add(Me.picLiveView, 0, 0)
            Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tlpMain.Location = New System.Drawing.Point(3, 3)
            Me.tlpMain.Name = "tlpMain"
            Me.tlpMain.RowCount = 1
            Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tlpMain.Size = New System.Drawing.Size(571, 382)
            Me.tlpMain.TabIndex = 0
            '
            'FlowLayoutPanel2
            '
            Me.FlowLayoutPanel2.AutoSize = True
            Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
            Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlowLayoutPanel2.Location = New System.Drawing.Point(404, 3)
            Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
            Me.FlowLayoutPanel2.Size = New System.Drawing.Size(164, 376)
            Me.FlowLayoutPanel2.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cboWhiteBalance)
            Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(158, 82)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "&White Balance"
            '
            'cboWhiteBalance
            '
            Me.cboWhiteBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboWhiteBalance.FormattingEnabled = True
            Me.cboWhiteBalance.Items.AddRange(New Object() {"<Coordinate Based>", "Auto", "Daylight", "Cloudy", "Tungsten", "Fluorescent", "Flash", "Shade", "Color Temperature", "Custom White Balance: PC-1", "Custom White Balance: PC-2", "Custom White Balance: PC-3"})
            Me.cboWhiteBalance.Location = New System.Drawing.Point(6, 19)
            Me.cboWhiteBalance.Name = "cboWhiteBalance"
            Me.cboWhiteBalance.Size = New System.Drawing.Size(121, 21)
            Me.cboWhiteBalance.TabIndex = 0
            '
            'picLiveView
            '
            Me.picLiveView.Cursor = System.Windows.Forms.Cursors.SizeAll
            Me.picLiveView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picLiveView.Location = New System.Drawing.Point(3, 3)
            Me.picLiveView.Name = "picLiveView"
            Me.picLiveView.Size = New System.Drawing.Size(395, 376)
            Me.picLiveView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picLiveView.TabIndex = 2
            Me.picLiveView.TabStop = False
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.AutoSize = True
            Me.TableLayoutPanel3.ColumnCount = 2
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
            Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 391)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(571, 35)
            Me.TableLayoutPanel3.TabIndex = 1
            '
            'FlowLayoutPanel3
            '
            Me.FlowLayoutPanel3.AutoSize = True
            Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.FlowLayoutPanel3.Controls.Add(Me.btnGrid)
            Me.FlowLayoutPanel3.Controls.Add(Me.btnZoomOut)
            Me.FlowLayoutPanel3.Controls.Add(Me.lblZoom)
            Me.FlowLayoutPanel3.Controls.Add(Me.btnZoomIn)
            Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
            Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
            Me.FlowLayoutPanel3.Size = New System.Drawing.Size(289, 29)
            Me.FlowLayoutPanel3.TabIndex = 0
            Me.FlowLayoutPanel3.WrapContents = False
            '
            'btnGrid
            '
            Me.btnGrid.Location = New System.Drawing.Point(3, 3)
            Me.btnGrid.Name = "btnGrid"
            Me.btnGrid.Size = New System.Drawing.Size(75, 23)
            Me.btnGrid.TabIndex = 0
            Me.btnGrid.Text = "&Grid"
            Me.btnGrid.UseVisualStyleBackColor = True
            '
            'btnZoomOut
            '
            Me.btnZoomOut.Location = New System.Drawing.Point(84, 3)
            Me.btnZoomOut.Name = "btnZoomOut"
            Me.btnZoomOut.Size = New System.Drawing.Size(75, 23)
            Me.btnZoomOut.TabIndex = 1
            Me.btnZoomOut.Text = "Zoom &Out"
            Me.btnZoomOut.UseVisualStyleBackColor = True
            '
            'lblZoom
            '
            Me.lblZoom.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblZoom.Location = New System.Drawing.Point(165, 0)
            Me.lblZoom.Name = "lblZoom"
            Me.lblZoom.Size = New System.Drawing.Size(40, 29)
            Me.lblZoom.TabIndex = 2
            Me.lblZoom.Text = "100%"
            Me.lblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnZoomIn
            '
            Me.btnZoomIn.Location = New System.Drawing.Point(211, 3)
            Me.btnZoomIn.Name = "btnZoomIn"
            Me.btnZoomIn.Size = New System.Drawing.Size(75, 23)
            Me.btnZoomIn.TabIndex = 3
            Me.btnZoomIn.Text = "Zoom &In"
            Me.btnZoomIn.UseVisualStyleBackColor = True
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.AutoSize = True
            Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
            Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(487, 3)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(81, 29)
            Me.FlowLayoutPanel1.TabIndex = 1
            '
            'btnClose
            '
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.Location = New System.Drawing.Point(3, 3)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 23)
            Me.btnClose.TabIndex = 0
            Me.btnClose.Text = "&Close"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'frmLiveView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnClose
            Me.ClientSize = New System.Drawing.Size(577, 429)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "frmLiveView"
            Me.ShowIcon = False
            Me.Text = "Live View"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.tlpMain.ResumeLayout(False)
            Me.tlpMain.PerformLayout()
            Me.FlowLayoutPanel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.picLiveView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.FlowLayoutPanel3.ResumeLayout(False)
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cboWhiteBalance As System.Windows.Forms.ComboBox
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents btnGrid As System.Windows.Forms.Button
        Friend WithEvents btnZoomOut As System.Windows.Forms.Button
        Friend WithEvents btnZoomIn As System.Windows.Forms.Button
        Friend WithEvents lblZoom As System.Windows.Forms.Label
        Friend WithEvents picLiveView As System.Windows.Forms.PictureBox
    End Class
End Namespace