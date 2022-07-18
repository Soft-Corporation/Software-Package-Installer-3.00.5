Imports MaterialSkin
Imports System.Net
Imports System.IO

Public Class Form1

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Vsc.Show()
    End Sub

    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Visual_Studio.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Libreoffice.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Edge.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Chrome.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Firefox.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        IObit_Unistaller.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Hwmonitor.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        _7zip.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        If Panel1.Visible = True Then

            Panel2.Show()
        Else
            Panel1.Show()
            Panel2.Hide()
        End If


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        If Panel2.Visible = True Then
            Panel2.Hide()
        Else
            Panel1.Hide()

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Notepad__.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Discord.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Steam.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Virtualbox.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Vmware.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Sky_Go.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Ccleaner.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Google_Drive.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Obs.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Flowgorithm.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)
        Teamviewer.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)
        Soft_Optimizer.Show()

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs)
        Gimp.Show()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs)
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs)
        Audacity.Show()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)
        Install_Creator.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        Shotcut.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs)
        Teamviewer.Show()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Teamviewer.Show()
    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs)
        Soft_Optimizer.Show()
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs)
        Gimp.Show()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Gimp.Show()
    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs)
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs)
        Audacity.Show()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Audacity.Show()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer5.Start()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()


        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer5.Stop()
            Timer6.Start()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Start()
            Timer8.Stop()
            Timer9.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Start()
            Timer9.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Start()


        End If



        Timer1.Start()


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Download.DownloadFileAsync(New Uri("Server Ftp Url"), Application.StartupPath & "\Updater.txt")

            Timer2.Start()
            Timer3.Start()
            Timer4.Start()
        End If





    End Sub

    Public WithEvents Download As New WebClient
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Panel2.Hide()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()



        szp.Show()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Soft_Optimizer.Show()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Install_Creator.Show()
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Shotcut.Show()
    End Sub

    Private Sub MaterialLabel7_Click(sender As Object, e As EventArgs)
        Shotcut.Show()
    End Sub

    Private Sub MaterialLabel6_Click(sender As Object, e As EventArgs)
        Install_Creator.Show()
    End Sub

    Private Sub MaterialLabel9_Click(sender As Object, e As EventArgs)
        Notepad__.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Notepad__.Show()
    End Sub

    Private Sub MaterialLabel10_Click(sender As Object, e As EventArgs)
        Discord.Show()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Discord.Show()
    End Sub

    Private Sub MaterialLabel11_Click(sender As Object, e As EventArgs)
        Steam.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Steam.Show()
    End Sub

    Private Sub MaterialLabel12_Click(sender As Object, e As EventArgs)
        Virtualbox.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Virtualbox.Show()
    End Sub

    Private Sub MaterialLabel13_Click(sender As Object, e As EventArgs)
        Vmware.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Vmware.Show()
    End Sub

    Private Sub MaterialLabel14_Click(sender As Object, e As EventArgs)
        Sky_Go.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Sky_Go.Show()
    End Sub

    Private Sub MaterialLabel15_Click(sender As Object, e As EventArgs)
        Ccleaner.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Ccleaner.Show()
    End Sub

    Private Sub MaterialLabel16_Click(sender As Object, e As EventArgs)
        Google_Drive.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Google_Drive.Show()
    End Sub

    Private Sub MaterialLabel17_Click(sender As Object, e As EventArgs)
        Obs.Show()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Obs.Show()
    End Sub

    Private Sub MaterialLabel18_Click(sender As Object, e As EventArgs)
        Flowgorithm.Show()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Flowgorithm.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialButton4_Click_1(sender As Object, e As EventArgs)
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

        szp.Hide()

    End Sub

    Private Sub MaterialLabel19_Click(sender As Object, e As EventArgs)
        Vsc.Show()
    End Sub



    Private Sub MaterialLabel20_Click(sender As Object, e As EventArgs)
        Visual_Studio.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles vsp.Click
        Visual_Studio.Show()
    End Sub

    Private Sub MaterialLabel21_Click(sender As Object, e As EventArgs)
        Firefox.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles fip.Click
        Firefox.Show()
    End Sub

    Private Sub MaterialLabel22_Click(sender As Object, e As EventArgs)
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles bdp.Click
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub MaterialLabel23_Click(sender As Object, e As EventArgs)
        Libreoffice.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles lbp.Click
        Libreoffice.Show()
    End Sub

    Private Sub MaterialLabel24_Click(sender As Object, e As EventArgs)
        Edge.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles edp.Click
        Edge.Show()
    End Sub

    Private Sub MaterialLabel25_Click(sender As Object, e As EventArgs)
        Chrome.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles chp.Click
        Chrome.Show()
    End Sub

    Private Sub MaterialLabel26_Click(sender As Object, e As EventArgs)
        IObit_Unistaller.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles up.Click
        IObit_Unistaller.Show()
    End Sub

    Private Sub MaterialLabel27_Click(sender As Object, e As EventArgs)
        Hwmonitor.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles hwp.Click
        Hwmonitor.Show()
    End Sub

    Private Sub MaterialLabel28_Click(sender As Object, e As EventArgs)
        _7zip.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles szp.Click
        _7zip.Show()
    End Sub

    Private Sub MaterialLabel29_Click(sender As Object, e As EventArgs)
        Trading_View.Show()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Trading_View.Show()
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Logitech_G_Hub.Show()
    End Sub

    Private Sub MaterialLabel30_Click(sender As Object, e As EventArgs)
        Logitech_G_Hub.Show()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Anydesk.Show()
    End Sub

    Private Sub MaterialLabel31_Click(sender As Object, e As EventArgs)
        Anydesk.Show()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        Opera.Show()

    End Sub

    Private Sub MaterialLabel41_Click(sender As Object, e As EventArgs)
        Opera.Show()
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        Opera_Gx.Show()
    End Sub

    Private Sub MaterialLabel40_Click(sender As Object, e As EventArgs)
        Opera_Gx.Show()
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        Vivaldi.Show()

    End Sub

    Private Sub MaterialLabel39_Click(sender As Object, e As EventArgs)
        Vivaldi.Show()

    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        OperaCB.Show()
    End Sub

    Private Sub MaterialLabel38_Click(sender As Object, e As EventArgs)
        OperaCB.Show()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        OnlyOffice.Show()
    End Sub

    Private Sub MaterialLabel37_Click(sender As Object, e As EventArgs)
        OnlyOffice.Show()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Rufus.Show()

    End Sub

    Private Sub MaterialLabel36_Click(sender As Object, e As EventArgs)
        Rufus.Show()

    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Python.Show()
    End Sub

    Private Sub MaterialLabel35_Click(sender As Object, e As EventArgs)
        Python.Show()
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Davinci_Resolve.Show()
    End Sub

    Private Sub MaterialLabel34_Click(sender As Object, e As EventArgs)
        Davinci_Resolve.Show()
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Openshot.Show()

    End Sub

    Private Sub MaterialLabel33_Click(sender As Object, e As EventArgs)
        Openshot.Show()
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Driver_Easy.Show()
    End Sub

    Private Sub MaterialLabel32_Click(sender As Object, e As EventArgs)
        Driver_Easy.Show()

    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel51_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        Iobit_Malware_Fighter.Show()

    End Sub

    Private Sub MaterialLabel50_Click(sender As Object, e As EventArgs)
        Iobit_Malware_Fighter.Show()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Show()
        Panel5.Hide()
        Panel6.Hide()


    End Sub

    Private Sub MaterialButton7_Click(sender As Object, e As EventArgs)
        Impostazioni.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Conf") Then


        Else

            Configurazione.Show()

        End If

    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        IObit_Software_Updater.Show()
    End Sub

    Private Sub MaterialLabel42_Click(sender As Object, e As EventArgs)
        IObit_Software_Updater.Show()

    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub MaterialLabel43_Click(sender As Object, e As EventArgs)
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        Soft_Launcher.Show()

    End Sub

    Private Sub MaterialLabel44_Click(sender As Object, e As EventArgs)
        Soft_Launcher.Show()
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Nox_Player.Show()

    End Sub

    Private Sub MaterialLabel45_Click(sender As Object, e As EventArgs)
        Nox_Player.Show()
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Telegram.Show()

    End Sub

    Private Sub MaterialLabel46_Click(sender As Object, e As EventArgs)
        Telegram.Show()

    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Dev_C__.Show()
    End Sub

    Private Sub MaterialLabel47_Click(sender As Object, e As EventArgs)
        Dev_C__.Show()
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        AlgoBuild.Show()

    End Sub

    Private Sub MaterialLabel48_Click(sender As Object, e As EventArgs)
        AlgoBuild.Show()
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        Crystaldiskmark.Show()

    End Sub

    Private Sub MaterialLabel49_Click(sender As Object, e As EventArgs)
        Crystaldiskmark.Show()

    End Sub

    Private Sub PictureBox50_Click_1(sender As Object, e As EventArgs) Handles PictureBox50.Click
        Crystaldiskinfo.Show()
    End Sub

    Private Sub MaterialLabel51_Click_1(sender As Object, e As EventArgs)
        Crystaldiskinfo.Show()

    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        Zoom.Show()
    End Sub

    Private Sub MaterialLabel61_Click(sender As Object, e As EventArgs)
        Zoom.Show()
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        Vlc.Show()

    End Sub

    Private Sub MaterialLabel60_Click(sender As Object, e As EventArgs)
        Vlc.Show()

    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        Epic_Games_Launcher.Show()
    End Sub

    Private Sub MaterialLabel59_Click(sender As Object, e As EventArgs)
        Epic_Games_Launcher.Show()
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        Battlenet.Show()
    End Sub

    Private Sub MaterialLabel58_Click(sender As Object, e As EventArgs)
        Battlenet.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Chrome_Canary.Show()
    End Sub

    Private Sub MaterialLabel57_Click(sender As Object, e As EventArgs)
        Chrome_Canary.Show()
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        Notion.Show()

    End Sub

    Private Sub MaterialLabel56_Click(sender As Object, e As EventArgs)
        Notion.Show()
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        Nvidia_Geforce_Experience.Show()
    End Sub

    Private Sub MaterialLabel55_Click(sender As Object, e As EventArgs)
        Nvidia_Geforce_Experience.Show()
    End Sub

    Private Sub MaterialButton8_Click(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Show()
        Panel6.Hide()



    End Sub

    Private Sub CircularProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-spi")
        Else


        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Stop()
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        Filezilla_Server.Show()

    End Sub

    Private Sub MaterialLabel52_Click(sender As Object, e As EventArgs)
        Filezilla_Server.Show()
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        Filezilla_Ser.Show()
    End Sub

    Private Sub MaterialLabel53_Click(sender As Object, e As EventArgs)
        Filezilla_Ser.Show()

    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        Advanced_Systemcare.Show()
    End Sub

    Private Sub MaterialLabel54_Click(sender As Object, e As EventArgs)
        Advanced_Systemcare.Show()
    End Sub

    Private Sub PictureBox70_Click(sender As Object, e As EventArgs) Handles PictureBox70.Click
        Smart_Defrag.Show()
    End Sub

    Private Sub MaterialLabel71_Click(sender As Object, e As EventArgs)
        Smart_Defrag.Show()
    End Sub

    Private Sub PictureBox69_Click(sender As Object, e As EventArgs) Handles PictureBox69.Click
        Iobit_Protected_Folder.Show()
    End Sub

    Private Sub MaterialLabel70_Click(sender As Object, e As EventArgs)
        Iobit_Protected_Folder.Show()
    End Sub

    Private Sub PictureBox68_Click(sender As Object, e As EventArgs) Handles PictureBox68.Click
        Itop_Vpn.Show()

    End Sub

    Private Sub MaterialLabel69_Click(sender As Object, e As EventArgs)
        Itop_Vpn.Show()
    End Sub

    Private Sub PictureBox67_Click(sender As Object, e As EventArgs) Handles PictureBox67.Click
        Droidcam.Show()
    End Sub

    Private Sub MaterialLabel68_Click(sender As Object, e As EventArgs)
        Droidcam.Show()
    End Sub

    Private Sub PictureBox66_Click(sender As Object, e As EventArgs) Handles PictureBox66.Click
        OpenOffice.Show()
    End Sub

    Private Sub MaterialLabel67_Click(sender As Object, e As EventArgs)
        OpenOffice.Show()
    End Sub

    Private Sub PictureBox65_Click(sender As Object, e As EventArgs) Handles PictureBox65.Click
        Ps_Remote_Play.Show()

    End Sub

    Private Sub MaterialLabel66_Click(sender As Object, e As EventArgs)
        Ps_Remote_Play.Show()
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click
        Itunes.Show()
    End Sub

    Private Sub MaterialLabel65_Click(sender As Object, e As EventArgs)
        Itunes.Show()

    End Sub

    Private Sub MaterialButton3_Click_1(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Impostazioni.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles vsp.Click
        Vsc.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panel2.Hide()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Vsc.Show()
        Vs.Show()
        Ed.Show()
        Ch.Show()
        Fi.Show()
        Bd.Show()
        u.Show()
        sz.Show()
        hw.Show()

        szp.Show()

        vscp.Show()
        vsp.Show()
        lbp.Show()
        edp.Show()
        chp.Show()
        fip.Show()
        bdp.Show()
        up.Show()
        hwp.Show()
        szp.Show()
        Lb.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        Lb.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        tv.Show()
        so.Show()
        gi.Show()
        ac.Show()
        au.Show()
        ic.Show()
        sh.Show()
        tr.Show()
        lh.Show()
        an.Show()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        szp.Hide()
        Lb.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()

        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Show()
        Panel5.Hide()
        Panel6.Hide()

        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()

        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        Lb.Hide()

        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Show()
        Panel6.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Show()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub

    Private Sub vscp_Click(sender As Object, e As EventArgs) Handles vscp.Click
        Visual.Show()
    End Sub

    Private Sub Vsc_Click(sender As Object, e As EventArgs) Handles Vsc.Click

    End Sub
End Class
