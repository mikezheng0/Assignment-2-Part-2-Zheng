Public Class Form1
    ' Constant values for different hair cutter base values
    Const decJSAMLEY As Decimal = 30D
    Const decPJOHNSON As Decimal = 45D
    Const decRCHAMBERS As Decimal = 40D
    Const decSPALLON As Decimal = 50D
    Const decLRENKINS As Decimal = 55D

    Dim decServiceArray As Decimal() = {30D, 40D, 50D, 200D, 60D, 50D}
    Dim decBaseCost As Decimal = 0

    Private Sub flickerEnable()
        btnAddService.Enabled = True
        cboHairdressers.Enabled = False
    End Sub

    Private Sub cboHairdressers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHairdressers.SelectedIndexChanged
        If (cboHairdressers.SelectedIndex = 0) Then
            decBaseCost = decJSAMLEY
        ElseIf (cboHairdressers.SelectedIndex = 1) Then
            decBaseCost = decPJOHNSON
        ElseIf (cboHairdressers.SelectedIndex = 2) Then
            decBaseCost = decRCHAMBERS
        ElseIf (cboHairdressers.SelectedIndex = 3) Then
            decBaseCost = decSPALLON
        ElseIf (cboHairdressers.SelectedIndex = 4) Then
            decBaseCost = decLRENKINS
        End If
        If (lstServices.SelectedIndex >= 0) Then
            flickerEnable()
        End If
    End Sub

    Private Sub lstServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServices.SelectedIndexChanged
        If (cboHairdressers.SelectedIndex >= 0) Then
            flickerEnable()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        ' Checks if anything is selected from the hairdressers combo box
        If (cboHairdressers.SelectedIndex >= 0) Then
            ' checks if there are any values in the current box so it can add the hairdresser 
            If (lstPrice.Items.Count = 0) Then
                lstDisplayedPrice.Items.Add(cboHairdressers.SelectedItem.ToString())
                lstPrice.Items.Add(decBaseCost.ToString("c"))
            End If
            ' checks if the added selection already exists in the box
            If (Not lstDisplayedPrice.Items.Contains(lstServices.SelectedItem)) Then
                lstDisplayedPrice.Items.Add(lstServices.SelectedItem)
                lstPrice.Items.Add(decServiceArray(lstServices.SelectedIndex).ToString("c"))
                btnCalculateTotal.Enabled = True
            Else
                MessageBox.Show("you may only add one service once!")
            End If
        End If
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim sum As Decimal = 0
        For i = 0 To lstPrice.Items.Count - 1
            sum += CDbl(lstPrice.Items.Item(i))
        Next
        lblTotaloutput.Text = sum.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstServices.SelectedIndex = -1

        lstPrice.Items.Clear()
        lstDisplayedPrice.Items.Clear()

        btnAddService.Enabled = False
        btnCalculateTotal.Enabled = False

        cboHairdressers.Enabled = True

        lblTotaloutput.Text = ""
    End Sub

End Class
