<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfectHairSalon
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
        Me.cboHairdressers = New System.Windows.Forms.ComboBox()
        Me.lstServices = New System.Windows.Forms.ListBox()
        Me.lstDisplayedSelection = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lblSelectService = New System.Windows.Forms.Label()
        Me.lblSelectHairdresser = New System.Windows.Forms.Label()
        Me.lblSelectedService = New System.Windows.Forms.Label()
        Me.lblAddedPrice = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotaloutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboHairdressers
        '
        Me.cboHairdressers.FormattingEnabled = True
        Me.cboHairdressers.Items.AddRange(New Object() {"Jane Samley", "Pat Johnson", "Ron Chambers", "Sue Pallon", "Laura Renkins"})
        Me.cboHairdressers.Location = New System.Drawing.Point(9, 40)
        Me.cboHairdressers.Margin = New System.Windows.Forms.Padding(2)
        Me.cboHairdressers.Name = "cboHairdressers"
        Me.cboHairdressers.Size = New System.Drawing.Size(173, 21)
        Me.cboHairdressers.TabIndex = 0
        Me.cboHairdressers.Text = "By Using Down Arrow"
        '
        'lstServices
        '
        Me.lstServices.FormattingEnabled = True
        Me.lstServices.Items.AddRange(New Object() {"Cut, Wash, Blowdry, and Style", "Colour", "Highlights", "Extensions", "Up do", "Wash, Blowdry, and Style"})
        Me.lstServices.Location = New System.Drawing.Point(185, 40)
        Me.lstServices.Margin = New System.Windows.Forms.Padding(2)
        Me.lstServices.Name = "lstServices"
        Me.lstServices.Size = New System.Drawing.Size(232, 303)
        Me.lstServices.TabIndex = 1
        '
        'lstDisplayedSelection
        '
        Me.lstDisplayedSelection.FormattingEnabled = True
        Me.lstDisplayedSelection.Location = New System.Drawing.Point(421, 40)
        Me.lstDisplayedSelection.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDisplayedSelection.Name = "lstDisplayedSelection"
        Me.lstDisplayedSelection.Size = New System.Drawing.Size(173, 303)
        Me.lstDisplayedSelection.TabIndex = 2
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(597, 40)
        Me.lstPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(154, 303)
        Me.lstPrice.TabIndex = 3
        '
        'lblSelectService
        '
        Me.lblSelectService.AutoSize = True
        Me.lblSelectService.Location = New System.Drawing.Point(183, 7)
        Me.lblSelectService.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectService.Name = "lblSelectService"
        Me.lblSelectService.Size = New System.Drawing.Size(85, 13)
        Me.lblSelectService.TabIndex = 4
        Me.lblSelectService.Text = "Select a Service"
        '
        'lblSelectHairdresser
        '
        Me.lblSelectHairdresser.AutoSize = True
        Me.lblSelectHairdresser.Location = New System.Drawing.Point(9, 7)
        Me.lblSelectHairdresser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectHairdresser.Name = "lblSelectHairdresser"
        Me.lblSelectHairdresser.Size = New System.Drawing.Size(102, 13)
        Me.lblSelectHairdresser.TabIndex = 5
        Me.lblSelectHairdresser.Text = "Select a Hairdresser"
        '
        'lblSelectedService
        '
        Me.lblSelectedService.AutoSize = True
        Me.lblSelectedService.Location = New System.Drawing.Point(418, 7)
        Me.lblSelectedService.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedService.Name = "lblSelectedService"
        Me.lblSelectedService.Size = New System.Drawing.Size(125, 13)
        Me.lblSelectedService.TabIndex = 6
        Me.lblSelectedService.Text = "Hairdresser and Services"
        '
        'lblAddedPrice
        '
        Me.lblAddedPrice.AutoSize = True
        Me.lblAddedPrice.Location = New System.Drawing.Point(595, 7)
        Me.lblAddedPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddedPrice.Name = "lblAddedPrice"
        Me.lblAddedPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblAddedPrice.TabIndex = 7
        Me.lblAddedPrice.Text = "Price"
        '
        'btnAddService
        '
        Me.btnAddService.Enabled = False
        Me.btnAddService.Location = New System.Drawing.Point(36, 359)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(114, 62)
        Me.btnAddService.TabIndex = 8
        Me.btnAddService.Text = "Add Service"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Enabled = False
        Me.btnCalculateTotal.Location = New System.Drawing.Point(212, 359)
        Me.btnCalculateTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(114, 62)
        Me.btnCalculateTotal.TabIndex = 9
        Me.btnCalculateTotal.Text = "Calculate Total Price"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(398, 359)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 62)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(583, 359)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 62)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(34, 251)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total:"
        '
        'lblTotaloutput
        '
        Me.lblTotaloutput.AutoSize = True
        Me.lblTotaloutput.Location = New System.Drawing.Point(36, 268)
        Me.lblTotaloutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotaloutput.Name = "lblTotaloutput"
        Me.lblTotaloutput.Size = New System.Drawing.Size(0, 13)
        Me.lblTotaloutput.TabIndex = 13
        '
        'frmPerfectHairSalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 444)
        Me.Controls.Add(Me.lblTotaloutput)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.lblAddedPrice)
        Me.Controls.Add(Me.lblSelectedService)
        Me.Controls.Add(Me.lblSelectHairdresser)
        Me.Controls.Add(Me.lblSelectService)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstDisplayedSelection)
        Me.Controls.Add(Me.lstServices)
        Me.Controls.Add(Me.cboHairdressers)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPerfectHairSalon"
        Me.Text = "PERFECT HAIR SALON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboHairdressers As System.Windows.Forms.ComboBox
    Friend WithEvents lstServices As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplayedSelection As System.Windows.Forms.ListBox
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectService As System.Windows.Forms.Label
    Friend WithEvents lblSelectHairdresser As System.Windows.Forms.Label
    Friend WithEvents lblSelectedService As System.Windows.Forms.Label
    Friend WithEvents lblAddedPrice As System.Windows.Forms.Label
    Friend WithEvents btnAddService As System.Windows.Forms.Button
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotaloutput As System.Windows.Forms.Label

End Class
