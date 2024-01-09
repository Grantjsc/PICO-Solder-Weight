Imports System.Data.OleDb
Imports System.Globalization

Module OCAP_Module
    Sub SaveData()
        Dim alarm, associate, mach, _date, partno, test, root, action As String
        Dim command As String

        alarm = OCAP_Form.txtAlarm.Text
        associate = OCAP_Form.txtAssociate.Text
        _date = Format(Now, "MM/dd/yyyy hh:mm ")
        mach = OCAP_Form.cboMachine.Text
        partno = OCAP_Form.txtPartNum.Text
        test = OCAP_Form.cboTest.Text
        root = OCAP_Form.cboRootCause.Text & ": " & OCAP_Form.txtOtherRC.Text
        action = OCAP_Form.cboAction.Text & ": " & OCAP_Form.txtOthersA.Text

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")
        Try
            con.Open()
            command = "INSERT INTO [OCAP_tb] ([Alarm],[Associate],[_date],[Machine],[Part_number],[test],[Root_cause],[Action]) VALUES (@alarm, @associate, @_date, @Machine, @Part_number, @test, @Root_cause, @Action)"
            Using cmd3 As OleDbCommand = New OleDbCommand(command, con)
                cmd3.Parameters.AddWithValue("@alarm", alarm)
                cmd3.Parameters.AddWithValue("@associate", associate)
                cmd3.Parameters.AddWithValue("@_date", _date)
                cmd3.Parameters.AddWithValue("@Machine", mach)
                cmd3.Parameters.AddWithValue("@Part_number", partno)
                cmd3.Parameters.AddWithValue("@test", test)
                cmd3.Parameters.AddWithValue("@Root_cause", root)
                cmd3.Parameters.AddWithValue("@Action", action)
                cmd3.ExecuteNonQuery()
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub OCAPForm_Condition()
        If OCAP_Form.cboMachine.Text = "" Then
            MsgBox("Please select machine!", MessageBoxIcon.Error)
            OCAP_Form.cboMachine.Focus()

        ElseIf OCAP_Form.cboTest.Text = "" Then
            MsgBox("Please select test item!", MessageBoxIcon.Error)
            OCAP_Form.cboTest.Focus()

        ElseIf OCAP_Form.cboRootCause.Text = "" Then
            MsgBox("Please select root cause!", MessageBoxIcon.Error)
            OCAP_Form.cboRootCause.Focus()

        ElseIf OCAP_Form.cboAction.Text = "" Then
            MsgBox("Please select action!", MessageBoxIcon.Error)
            OCAP_Form.cboAction.Focus()

        ElseIf OCAP_Form.txtOtherRC.Enabled = True And OCAP_Form.txtOtherRC.Text = "" Then
            MsgBox("Please enter root cause!", MessageBoxIcon.Error)
            OCAP_Form.txtOtherRC.Focus()

        ElseIf OCAP_Form.txtOthersA.Enabled = True And OCAP_Form.txtOthersA.Text = "" Then
            MsgBox("Please enter action!", MessageBoxIcon.Error)
            OCAP_Form.txtOthersA.Focus()

        Else
            SaveData()
            Main_Form.btnSolderCutter.Enabled = True
            Main_Form.btnSolderWeight.Enabled = True
            Function_Module.PurgeAfterOCAP()
            OCAP_Form.Close()
        End If
    End Sub

    Sub RootCauseSelect()
        If OCAP_Form.cboRootCause.Text = "4. Others (Input root Cause)" Then
            OCAP_Form.txtOtherRC.Enabled = True
        Else
            OCAP_Form.txtOtherRC.Enabled = False
        End If
    End Sub

    Sub ActionSelect()
        If OCAP_Form.cboAction.Text = "5. Others ( Input Action)" Then
            OCAP_Form.txtOthersA.Enabled = True
        Else
            OCAP_Form.txtOthersA.Enabled = False
        End If
    End Sub
End Module