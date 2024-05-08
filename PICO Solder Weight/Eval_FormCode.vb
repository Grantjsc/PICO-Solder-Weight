Imports System.IO.Ports
Imports System.Threading

Module Eval_Module

    Public txt As String
    Public retext As String

    Public data() As Decimal '= {12.0, 13.0, 13.33, 11.24}
    Public count As Integer
    Public param As String
    Public RealData As String

    Public Weight As Decimal = 0.00
    Public stopwatch As New Stopwatch()
    Public isTimerRunning As Boolean = False
    Public Evaluation As Boolean = False
    Sub Weighing()
        If RealData > 3.0 Then
            If RealData > Weight Then
                Weight = RealData
                Stopwatch.Restart()
            ElseIf RealData = 0.00 AndAlso isTimerRunning Then
                Stopwatch.Stop()
                Weight = 0.00
                isTimerRunning = False
            ElseIf RealData > 0.00 Then
                isTimerRunning = True
            End If

            If Stopwatch.ElapsedMilliseconds >= 4000 Then

                Eval_Form.SerialPort1.WriteLine("SP")
                Thread.Sleep(100)

                ReDim Preserve data(count)
                data(count) = Decimal.Parse(RealData)
                'data(count) = RealData
                count += 1
                Eval_Form.lstResult.Items.Add(count & ". " & RealData)
                Eval_Form.lstResult.SelectedIndex = Eval_Form.lstResult.Items.Count - 1

                stopwatch.Stop()
                Weight = 0.00
                isTimerRunning = False

                Eval_Form.Timer1.Enabled = False
                Eval_Form.SerialPort1.WriteLine("Z")
                Thread.Sleep(500)
                Eval_Form.SerialPort1.WriteLine("CP")

                Eval_Form.btnExitEval.Enabled = False
                Eval_Form.btnSave.Enabled = True

            End If
        Else

        End If
    End Sub

    Public get_FolderPath As String = "C:\Eval History\PICO Solder Weight Eval.csv"
    Public get_message As String

    Sub saveEval()

        Dim dateNtime As String = Date.Now.ToString("yyyy/MM/dd HH:mm tt ")

        get_message = vbCrLf & "Name" & "," & "Kind of Eval" & "," & "Result" & "," & "Date and Time" & vbCrLf
        If Eval_Form.txtName.Text = "" Then
            MsgBox("Please enter your name", MsgBoxStyle.Critical)
            Eval_Form.txtName.Focus()
        Else

            Try
                For n As Integer = 0 To data.Length - 1
                    If data(n) > 0 Then
                        get_message = get_message & Eval_Form.txtName.Text & "," & Eval_Form.txtKindOfEval.Text & "," & data(n).ToString & "," & dateNtime & vbCrLf
                    End If
                Next
                My.Computer.FileSystem.WriteAllText(get_FolderPath, get_message, True)
                'MessageBox.Show("The data is saved in " & get_FolderPath)

                Eval_Form.txtEvalReading.Text = ""

                If Eval_Form.SerialPort1.IsOpen Then
                    Eval_Form.SerialPort1.Close()
                End If

                count = 0
                Eval_Form.lstResult.Items.Clear()
                Array.Clear(data, 0, data.Length)

                Eval_Form.txtName.Text = ""
                Eval_Form.txtKindOfEval.Text = ""

                Main_Form.PanelEval.Visible = False
                Main_Form.btnEval.FillColor = Color.Transparent
                Main_Form.btnEval.ForeColor = Color.White

                Main_Form.btnEval.Image = My.Resources.evaluation

                Main_Form.btnSolderWeight.Enabled = True
                Main_Form.btnSolderCutter.Enabled = True
                Main_Form.btnBuyOff.Enabled = True

                Eval_Form.Timer1.Enabled = False
                Evaluation = False

                Eval_Form.Close()
            Catch ex As Exception
                MsgBox(ex, vbCritical)
            End Try

        End If
    End Sub

End Module