Public Class Main


    Private Var1 As Double
    Private Var2 As Double

    'Varible to hold temporary values
    Private Temp As Double

    'variable for Memory storage
    Private Memory As Double

    'True if "." is use else false
    Private Period As Boolean

    'variable to hold Operater
    Private MathOperator As String

    Private Status As Boolean

    Private Sub btnNum7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum7.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(7)
        Else
            txtDisplay.Text = 7
            Status = False
        End If
    End Sub

    Private Sub btnNum8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum8.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(8)
        Else
            txtDisplay.Text = 8
            Status = False
        End If
    End Sub

    Private Sub btnNum9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum9.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(9)
        Else
            txtDisplay.Text = 9
            Status = False
        End If
    End Sub

    Private Sub btnNum6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum6.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(6)
        Else
            txtDisplay.Text = 6
            Status = False
        End If
    End Sub

    Private Sub btnNum5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum5.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(5)
        Else
            txtDisplay.Text = 5
            Status = False
        End If
    End Sub

    Private Sub btnNum4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum4.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(4)
        Else
            txtDisplay.Text = 4
            Status = False
        End If
    End Sub

    Private Sub btnNum1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum1.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(1)
        Else
            txtDisplay.Text = 1
            Status = False
        End If
    End Sub

    Private Sub btnNum2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum2.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(2)
        Else
            txtDisplay.Text = 2
            Status = False
        End If
    End Sub

    Private Sub btnNum3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum3.Click
        If Status = False Then
            txtDisplay.Text = txtDisplay.Text + CStr(3)
        Else
            txtDisplay.Text = 3
            Status = False
        End If
    End Sub

    Private Sub btnNum0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum0.Click
        If Status = False Then
            If txtDisplay.Text.Length > 0 Then
                txtDisplay.Text = txtDisplay.Text + CStr(0)
            End If
        End If
    End Sub

    Private Sub btnNumPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumPeriod.Click
        If Status = False Then
            If Period = False Then
                If txtDisplay.Text.Length > 0 Then
                    txtDisplay.Text = txtDisplay.Text + "."
                Else
                    txtDisplay.Text = "0."
                End If
                Period = True
            End If
        End If
    End Sub

    Private Sub btnNumSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumSign.Click
        If Status = False Then
            If txtDisplay.Text.Length > 0 Then
                Var1 = -1 * CDbl(txtDisplay.Text)
                txtDisplay.Text = CStr(Var1)
            End If
        End If
    End Sub

    Private Sub btnOperatorAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperatorAdd.Click
        If txtDisplay.Text.Length <> 0 Then
            If MathOperator = "" Then
                Var1 = CDbl(txtDisplay.Text)
                txtDisplay.Text = ""
            Else
                Calculate()
            End If
            MathOperator = "Add"
            period = False
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If txtDisplay.Text.Length <> 0 AndAlso Var1 <> 0 Then
            Calculate()
            MathOperator = ""
            Period = False
        End If
    End Sub

    Private Sub btnOperatorSubt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperatorSubt.Click
        If txtDisplay.Text.Length <> 0 Then
            If MathOperator = "" Then
                Var1 = CDbl(txtDisplay.Text)
                txtDisplay.Text = ""
            Else
                Calculate()
            End If
            MathOperator = "Sub"
            Period = False
        End If
    End Sub

    Private Sub btnOperatorMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperatorMulti.Click
        If txtDisplay.Text.Length <> 0 Then
            If MathOperator = "" Then
                Var1 = CDbl(txtDisplay.Text)
                txtDisplay.Text = ""
            Else
                Calculate()
            End If
            MathOperator = "Mult"
            Period = False
        End If
    End Sub

    Private Sub btnOperatorDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperatorDiv.Click
        If txtDisplay.Text.Length <> 0 Then
            If MathOperator = "" Then
                Var1 = CDbl(txtDisplay.Text)
                txtDisplay.Text = ""
            Else
                Calculate()
            End If
            MathOperator = "Div"
            Period = False
        End If
    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        If txtDisplay.Text.Length <> 0 Then
            Temp = CDbl(txtDisplay.Text)
            Temp = System.Math.Sqrt(Temp)
            txtDisplay.Text = CStr(Temp)
            Period = False
        End If
    End Sub

    Private Sub btnPow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPow.Click
        If txtDisplay.Text.Length <> 0 Then
            If MathOperator = "" Then
                Var1 = CDbl(txtDisplay.Text)
                txtDisplay.Text = ""
            Else
                Calculate()
            End If
            MathOperator = "Pow"
            Period = False
        End If
    End Sub

    Private Sub btnInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInverse.Click
        If txtDisplay.Text.Length <> 0 Then
            Temp = CDbl(txtDisplay.Text)
            Temp = 1 / Temp
            txtDisplay.Text = CStr(Temp)
            Period = False
        End If
    End Sub

    Private Sub btnMemoryPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemoryPlus.Click
        If txtDisplay.Text.Length > 0 Then
            Memory = Memory + CDbl(txtDisplay.Text)
            lblMemStatus.Text = "M"
        End If
    End Sub

    Private Sub btnMemoryMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemoryMinus.Click
        If txtDisplay.Text.Length > 0 Then
            Memory = Memory - CDbl(txtDisplay.Text)
            lblMemStatus.Text = "M"
        End If
    End Sub

    Private Sub btnMemoryRecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemoryRecall.Click
        If lblMemStatus.Text = "M" Then
            txtDisplay.Text = CStr(Memory)
            Status = True
        End If
    End Sub

    Private Sub btnCLRCurr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLRCurr.Click
        txtDisplay.Text = ""
        Period = False
    End Sub

    Private Sub btnCLR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLR.Click
        txtDisplay.Text = ""
        Var1 = 0
        var2 = 0
        MathOperator = ""
        Period = False
    End Sub

    Private Sub btnBackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackspace.Click
        Dim ch As Char
        Dim i As Int16
        If txtDisplay.Text.Length > 0 Then
            ch = txtDisplay.Text.Chars(txtDisplay.Text.Length - 1)
            If ch = "." Then
                Period = False
            End If

            i = txtDisplay.Text.Length

            txtDisplay.Text = txtDisplay.Text.Remove(i - 1, 1)
        End If
    End Sub

    Public Sub Calculate()
        var2 = CDbl(txtDisplay.Text)
        If MathOperator = "Add" Then
            Var1 = Var1 + Var2
        ElseIf MathOperator = "Sub" Then
            Var1 = Var1 - Var2
        ElseIf MathOperator = "Mult" Then
            Var1 = Var1 * Var2
        ElseIf MathOperator = "Div" Then
            Var1 = Var1 / Var2
        ElseIf MathOperator = "Sqrt" Then
            Exit Sub
        ElseIf MathOperator = "Pow" Then
            Var1 = System.Math.Pow(Var1, Var2)
        ElseIf MathOperator = "Inve" Then
            Exit Sub
        End If
        txtDisplay.Text = CStr(Var1)
        Status = True
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class