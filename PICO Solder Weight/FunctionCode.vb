Imports System.Configuration

Module Function_Module

    Public PNseries As Integer
    Public NewWeightmg As Decimal

    Public OldWeight As Decimal
    Public NewOCAP As Integer
    Public OldOCAP As Integer

    Sub GetSeries()
        Dim str As String
        str = Form1.txtPartNo.Text
        PNseries = str.Substring(1, 3)
        Console.WriteLine(PNseries)
    End Sub

    Sub GetNewmg()
        NewWeightmg = CDec(Form1.txtWeight.Text)
    End Sub

    Sub GetOldmg()
        Dim Oldmg As String = System.Configuration.ConfigurationManager.AppSettings("mg")
        Console.WriteLine(Oldmg)

        OldWeight = Oldmg
    End Sub

    Sub GetOldOCAP()
        Dim OCAPcount As String = System.Configuration.ConfigurationManager.AppSettings("OCAP")
        Console.WriteLine(OCAPcount)

        OldOCAP = CInt(OCAPcount)
    End Sub

    Sub IncOCAP()
        NewOCAP = CInt(OldOCAP) + 1
    End Sub
    Sub ResetOCAP()
        NewOCAP = 0
    End Sub

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Sub ChangeMg()
        config.AppSettings.Settings("mg").Value = NewWeightmg ' Rewrite Weight(mg)
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub ChangeOCAP()
        config.AppSettings.Settings("OCAP").Value = NewOCAP ' Rewrite Weight(mg)
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

End Module