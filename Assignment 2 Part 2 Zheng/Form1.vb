Public Class Form1
    ' Constant values for different hair cutter base values
    Const decJSAMLEY As Decimal = 30D
    Const decPJOHNSON As Decimal = 45D
    Const decRCHAMBERS As Decimal = 40D
    Const decSPALLON As Decimal = 50D
    Const decLRENKINS As Decimal = 55D

    Dim decBaseCost As Decimal = 0
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
    End Sub

    Private Sub lstServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServices.SelectedIndexChanged

    End Sub
End Class
