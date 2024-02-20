Imports System.Configuration
Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices

Module ChangeCOM_Module

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public WeighingSerial As String
    Public LockSerial As String
    Public NewWeighingSerial As String
    Public NewLockSerial As String

    Sub GetWeighingSerialName()
        Dim serial1 As String = System.Configuration.ConfigurationManager.AppSettings("WeighingCOM")
        Console.WriteLine(serial1)

        WeighingSerial = serial1
    End Sub
    Sub GetLockSerialName()
        Dim serial2 As String = System.Configuration.ConfigurationManager.AppSettings("LockArdCOM")
        Console.WriteLine(serial2)

        LockSerial = serial2
    End Sub

    Sub GetCOMport1()
        NewWeighingSerial = ChangeComPort_Form.cboWeighing.Text
    End Sub
    Sub ChangeWeighingComPort()
        config.AppSettings.Settings("WeighingCOM").Value = NewWeighingSerial ' Rewrite Ohaus Weighing Scale COM name
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub GetCOMport2()
        NewLockSerial = ChangeComPort_Form.cboLock.Text
    End Sub
    Sub ChangeLockComPort()
        config.AppSettings.Settings("LockArdCOM").Value = NewLockSerial ' Rewrite Door Lock (Arduino) COM name
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub LoadComPort1()
        Dim portNameWS As String() = SerialPort.GetPortNames()
        For Each portName As String In portNameWS
            ChangeComPort_Form.cboWeighing.Items.Add(portName)
        Next
    End Sub

    Sub LoadComPort2()
        Dim portNameArd As String() = SerialPort.GetPortNames()
        For Each ComPortName As String In portNameArd
            ChangeComPort_Form.cboLock.Items.Add(ComPortName)
        Next
    End Sub

    Sub ChangeNames()
        If ChangeComPort_Form.cboWeighing.Text = "" And ChangeComPort_Form.cboLock.Text = "" Then
            MsgBox("Please select SerialPort name!", MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(ChangeComPort_Form.cboWeighing.Text) Then
            GetCOMport2()
            ChangeLockComPort()

            ChangeComPort_Form.cboWeighing.Items.Clear()
            ChangeComPort_Form.cboLock.Items.Clear()
            ChangeComPort_Form.Close()
        ElseIf String.IsNullOrEmpty(ChangeComPort_Form.cboLock.Text) Then
            GetCOMport1()
            ChangeWeighingComPort()

            ChangeComPort_Form.cboWeighing.Items.Clear()
            ChangeComPort_Form.cboLock.Items.Clear()
            ChangeComPort_Form.Close()
        Else

            GetCOMport1()
            GetCOMport2()
            ChangeWeighingComPort()
            ChangeLockComPort()

            ChangeComPort_Form.cboWeighing.Items.Clear()
            ChangeComPort_Form.cboLock.Items.Clear()
            ChangeComPort_Form.Close()

        End If
    End Sub

End Module