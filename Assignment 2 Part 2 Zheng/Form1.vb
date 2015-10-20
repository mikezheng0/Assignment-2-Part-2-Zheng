' Mike Zheng
' Assignment 2 part 2 - this lab calculates the final price after adding services used for a companyss
' I Mike Zheng, 000458657 certify that this material is my original work. 
' No other person's work has been used without due acknowledgement. I 
' have not made my work available to anyone else.

Public Class frmPerfectHairSalon
    ' Constant values for different hair cutter base values
    Const decJSAMLEY As Decimal = 30D
    Const decPJOHNSON As Decimal = 45D
    Const decRCHAMBERS As Decimal = 40D
    Const decSPALLON As Decimal = 50D
    Const decLRENKINS As Decimal = 55D

    ' Constant Values for the various services
    Const decCUT As Decimal = 50D
    Const decCOLOUR As Decimal = 40D
    Const decHIGHLIGHTS As Decimal = 50D
    Const decEXTENSIONS As Decimal = 200D
    Const decUPDO As Decimal = 60D
    Const decSTYLE As Decimal = 30D

    Dim decBaseCost As Decimal = 0
    Dim boolFirstAddFlag As Boolean = True

    Function DetermineService(ByVal intSelection As Integer) As Decimal
        Dim decServiceCost As Decimal = 0
        Select Case intSelection
            Case 0
                decServiceCost = decCUT
            Case 1
                decServiceCost = decCOLOUR
            Case 2
                decServiceCost = decHIGHLIGHTS
            Case 3
                decServiceCost = decEXTENSIONS
            Case 4
                decServiceCost = decUPDO
            Case 5
                decServiceCost = decSTYLE
        End Select
        Return decServiceCost
    End Function

    ' When the index is changed it will set a base cost and enable the add service button if a service is already selected
    Private Sub cboHairdressers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHairdressers.SelectedIndexChanged
        Select Case cboHairdressers.SelectedIndex
            Case 0
                decBaseCost = decJSAMLEY
            Case 1
                decBaseCost = decPJOHNSON
            Case 2
                decBaseCost = decRCHAMBERS
            Case 3
                decBaseCost = decSPALLON
            Case 4
                decBaseCost = decLRENKINS
        End Select
        If (lstServices.SelectedIndex >= 0) Then
            btnAddService.Enabled = True
        End If
    End Sub

    ' Checks if a hairdresser is selected and will enable the add services button if it is 
    Private Sub lstServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServices.SelectedIndexChanged
        If (cboHairdressers.SelectedIndex >= 0) Then
            btnAddService.Enabled = True
        End If
    End Sub

    ' Closes the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        ' Checks if anything is selected from the hairdressers combo box
        If (cboHairdressers.SelectedIndex >= 0) Then
            ' checks if the flag has been triggered
            If (boolFirstAddFlag) Then
                lstDisplayedSelection.Items.Add(cboHairdressers.SelectedItem.ToString() & " Base Price")
                lstPrice.Items.Add(decBaseCost.ToString("c"))
                cboHairdressers.Enabled = False
                boolFirstAddFlag = False
            End If
            ' checks if the added selection already exists in the box
            If (Not lstDisplayedSelection.Items.Contains(lstServices.SelectedItem)) Then
                lstDisplayedSelection.Items.Add(lstServices.SelectedItem)
                lstPrice.Items.Add(DetermineService(lstServices.SelectedIndex).ToString("c"))
                btnCalculateTotal.Enabled = True
            End If
        End If
    End Sub

    ' totals the price listbox
    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim sum As Decimal = 0

        For i = 0 To lstPrice.Items.Count - 1
            sum += CDbl(lstPrice.Items.Item(i))
        Next

        lblTotaloutput.Text = sum.ToString("c")
    End Sub

    ' Resets the form
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the selection from the listbox
        lstServices.ClearSelected()

        ' Clears the price and services
        lstPrice.Items.Clear()
        lstDisplayedSelection.Items.Clear()

        ' Redisable the buttons and enable a hairdresser selection
        btnAddService.Enabled = False
        btnCalculateTotal.Enabled = False
        cboHairdressers.Enabled = True

        ' Resets the output message 
        lblTotaloutput.Text = ""

        ' Resets the Flag
        boolFirstAddFlag = True
    End Sub

End Class
