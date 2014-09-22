﻿Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        '1
        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text
        '2
        'Checkpoint
        If Not (IsNumeric(st1) And IsNumeric(st2)) Then
            MessageBox.Show("Please, enter numbers!")
            Return
        End If

        '3
        'Clean area

   
        num1 = CDbl(st1)
        num2 = CDbl(st2)
        '4

        'Checkpoint
        If Not (num1 >= 0 And num2 >= 0) Then
            MessageBox.Show("Please, enter non-negative numbers!")
            Return
        End If

            Dim result As String

            If num1 > num2 Then
                result = "The larger number is " & num1
            ElseIf num2 > num1 Then
                result = "The larger number is " & num2
            Else
                result = "They are equal"
            End If


            txtResult.Text = result





    End Sub

End Class
