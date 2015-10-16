<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstDisplayedPrice = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lblSelectService = New System.Windows.Forms.Label()
        Me.lblSelectHairdresser = New System.Windows.Forms.Label()
        Me.lblSelectedService = New System.Windows.Forms.Label()
        Me.lblAddedPrice = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboHairdressers
        '
        Me.cboHairdressers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHairdressers.FormattingEnabled = True
        Me.cboHairdressers.Items.AddRange(New Object() {"Jane Samley", "Pat Johnson", "Ron Chambers", "Sue Pallon", "Laura Renkins"})
        Me.cboHairdressers.Location = New System.Drawing.Point(12, 49)
        Me.cboHairdressers.Name = "cboHairdressers"
        Me.cboHairdressers.Size = New System.Drawing.Size(229, 24)
        Me.cboHairdressers.TabIndex = 0
        '
        'lstServices
        '
        Me.lstServices.FormattingEnabled = True
        Me.lstServices.ItemHeight = 16
        Me.lstServices.Items.AddRange(New Object() {"Cut, Wash, Blowdry, and Style", "Colour", "Highlights", "Extensions", "Up do", "Wash, Blowdry, and Style"})
        Me.lstServices.Location = New System.Drawing.Point(247, 49)
        Me.lstServices.Name = "lstServices"
        Me.lstServices.Size = New System.Drawing.Size(308, 372)
        Me.lstServices.TabIndex = 1
        '
        'lstDisplayedPrice
        '
        Me.lstDisplayedPrice.FormattingEnabled = True
        Me.lstDisplayedPrice.ItemHeight = 16
        Me.lstDisplayedPrice.Location = New System.Drawing.Point(561, 49)
        Me.lstDisplayedPrice.Name = "lstDisplayedPrice"
        Me.lstDisplayedPrice.Size = New System.Drawing.Size(229, 372)
        Me.lstDisplayedPrice.TabIndex = 2
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 16
        Me.lstPrice.Location = New System.Drawing.Point(796, 49)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(204, 372)
        Me.lstPrice.TabIndex = 3
        '
        'lblSelectService
        '
        Me.lblSelectService.AutoSize = True
        Me.lblSelectService.Location = New System.Drawing.Point(244, 9)
        Me.lblSelectService.Name = "lblSelectService"
        Me.lblSelectService.Size = New System.Drawing.Size(110, 17)
        Me.lblSelectService.TabIndex = 4
        Me.lblSelectService.Text = "Select a Service"
        '
        'lblSelectHairdresser
        '
        Me.lblSelectHairdresser.AutoSize = True
        Me.lblSelectHairdresser.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectHairdresser.Name = "lblSelectHairdresser"
        Me.lblSelectHairdresser.Size = New System.Drawing.Size(137, 17)
        Me.lblSelectHairdresser.TabIndex = 5
        Me.lblSelectHairdresser.Text = "Select a Hairdresser"
        '
        'lblSelectedService
        '
        Me.lblSelectedService.AutoSize = True
        Me.lblSelectedService.Location = New System.Drawing.Point(558, 9)
        Me.lblSelectedService.Name = "lblSelectedService"
        Me.lblSelectedService.Size = New System.Drawing.Size(168, 17)
        Me.lblSelectedService.TabIndex = 6
        Me.lblSelectedService.Text = "Hairdresser and Services"
        '
        'lblAddedPrice
        '
        Me.lblAddedPrice.AutoSize = True
        Me.lblAddedPrice.Location = New System.Drawing.Point(793, 9)
        Me.lblAddedPrice.Name = "lblAddedPrice"
        Me.lblAddedPrice.Size = New System.Drawing.Size(40, 17)
        Me.lblAddedPrice.TabIndex = 7
        Me.lblAddedPrice.Text = "Price"
        '
        'btnAddService
        '
        Me.btnAddService.Enabled = False
        Me.btnAddService.Location = New System.Drawing.Point(48, 442)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(152, 76)
        Me.btnAddService.TabIndex = 8
        Me.btnAddService.Text = "Add Service"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Enabled = False
        Me.btnCalculateTotal.Location = New System.Drawing.Point(283, 442)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(152, 76)
        Me.btnCalculateTotal.TabIndex = 9
        Me.btnCalculateTotal.Text = "Calculate Total Price"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(530, 442)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(152, 76)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(777, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 76)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 546)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.lblAddedPrice)
        Me.Controls.Add(Me.lblSelectedService)
        Me.Controls.Add(Me.lblSelectHairdresser)
        Me.Controls.Add(Me.lblSelectService)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstDisplayedPrice)
        Me.Controls.Add(Me.lstServices)
        Me.Controls.Add(Me.cboHairdressers)
        Me.Name = "Form1"
        Me.Text = "PERFECT HAIR SALON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboHairdressers As System.Windows.Forms.ComboBox
    Friend WithEvents lstServices As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplayedPrice As System.Windows.Forms.ListBox
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectService As System.Windows.Forms.Label
    Friend WithEvents lblSelectHairdresser As System.Windows.Forms.Label
    Friend WithEvents lblSelectedService As System.Windows.Forms.Label
    Friend WithEvents lblAddedPrice As System.Windows.Forms.Label
    Friend WithEvents btnAddService As System.Windows.Forms.Button
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
