Public Class Settings

    Public objHost As SkinEditor.Interfaces.IHost

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objHost.SetSetting("TestSetting", TextBox1.Text)
        objHost.SaveSettings()
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = objHost.GetSetting("TestSetting")
    End Sub

End Class