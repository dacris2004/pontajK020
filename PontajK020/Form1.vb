Imports System.DateTime
Imports System.IO
Imports System.Net


Public Class frmMain
    Dim Ora As Date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load employees names from file
        Dim USERS_FILE As String = "users.txt"
        If File.Exists(USERS_FILE) Then
            Dim objUsersReader As New System.IO.StreamReader(USERS_FILE)
            lblUser1.Text = objUsersReader.ReadLine
            lblUser2.Text = objUsersReader.ReadLine
            lblUser3.Text = objUsersReader.ReadLine
            btnUser1.Visible = CBool(Len(lblUser1.Text))
            btnUser2.Visible = CBool(Len(lblUser2.Text))
            btnUser3.Visible = CBool(Len(lblUser3.Text))
            objUsersReader.Close()
        Else
            MessageBox.Show("Nu exista fisierul cu angajati!")
            Application.Exit()
        End If
    End Sub

    Private Sub btnUser1_Click(sender As Object, e As EventArgs) Handles btnUser1.Click
        If btnUser1.Text = "status" Then
            btnUser1.Text = "Sosire"
            btnUser1.BackColor = Color.Green
            Ora = Date.Now
        ElseIf btnUser1.Text = "Sosire" Then
            btnUser1.Text = "Plecare"
            btnUser1.BackColor = Color.Red
            Ora = Date.Now
        Else
            btnUser1.Text = "Sosire"
            btnUser1.BackColor = Color.Green
            Ora = Date.Now
        End If
        listInfoPontaj.Items.Clear()
        listInfoPontaj.Items.Insert(0, lblUser1.Text & " [" & btnUser1.Text & "] " & CStr(Ora.Hour) & ":" & CStr(Ora.Minute))
        listInfoPontaj.BackColor = btnUser1.BackColor
        btnUser2.Text = "status"
        btnUser2.BackColor = btnPonteaza.BackColor
        btnUser3.Text = "status"
        btnUser3.BackColor = btnPonteaza.BackColor
        lblInfo.Text = ""
    End Sub

    Private Sub btnUser2_Click(sender As Object, e As EventArgs) Handles btnUser2.Click
        If btnUser2.Text = "status" Then
            btnUser2.Text = "Sosire"
            btnUser2.BackColor = Color.Green
            Ora = Date.Now
        ElseIf btnUser2.Text = "Sosire" Then
            btnUser2.Text = "Plecare"
            btnUser2.BackColor = Color.Red
            Ora = Date.Now
        Else
            btnUser2.Text = "Sosire"
            btnUser2.BackColor = Color.Green
            Ora = Date.Now
        End If
        listInfoPontaj.Items.Clear()
        listInfoPontaj.Items.Insert(0, lblUser2.Text & " [" & btnUser2.Text & "] " & CStr(Ora.Hour) & ":" & CStr(Ora.Minute))
        listInfoPontaj.BackColor = btnUser2.BackColor
        btnUser1.Text = "status"
        btnUser1.BackColor = btnPonteaza.BackColor
        btnUser3.Text = "status"
        btnUser3.BackColor = btnPonteaza.BackColor
        lblInfo.Text = ""
    End Sub

    Private Sub btnUser3_Click(sender As Object, e As EventArgs) Handles btnUser3.Click
        If btnUser3.Text = "status" Then
            btnUser3.Text = "Sosire"
            btnUser3.BackColor = Color.Green
            Ora = Date.Now
        ElseIf btnUser3.Text = "Sosire" Then
            btnUser3.Text = "Plecare"
            btnUser3.BackColor = Color.Red
            Ora = Date.Now
        Else
            btnUser3.Text = "Sosire"
            btnUser3.BackColor = Color.Green
            Ora = Date.Now
        End If
        listInfoPontaj.Items.Clear()
        listInfoPontaj.Items.Insert(0, lblUser3.Text & " [" & btnUser3.Text & "] " & CStr(Ora.Hour) & ":" & CStr(Ora.Minute))
        listInfoPontaj.BackColor = btnUser3.BackColor
        btnUser1.Text = "status"
        btnUser1.BackColor = btnPonteaza.BackColor
        btnUser2.Text = "status"
        btnUser2.BackColor = btnPonteaza.BackColor
        lblInfo.Text = ""
    End Sub

    Private Sub btnPonteaza_Click(sender As Object, e As EventArgs) Handles btnPonteaza.Click
        If listInfoPontaj.Items.Count = 0 Then
            MsgBox("Selectati Sosire sau Plecare pentru un angajat!", vbCritical, "Info")
            Exit Sub
        End If

        If MsgBox("Se efectueaza pontarea " & listInfoPontaj.Items(0).ToString, MsgBoxStyle.YesNo, "Info") = vbYes Then
            'efectueaza pontarea pentru angajatul pontat
            '===========================================
            Call RecordData(listInfoPontaj.Items(0).ToString)
            '===========================================
            lblInfo.Text = "OK!"
        End If
    End Sub

    Private Sub RecordData(Info As String)
        On Error Resume Next
        'split Info into angajat, sosire or plecare, time
        Dim ziua As String
        Dim angajat As String
        Dim action As String
        Dim hour_action As String

        ziua = Format(Date.Now, "yyyy-MM-dd")

        angajat = Strings.Left(Info, InStr(Info, "[", CompareMethod.Text) - 2)
        action = LCase(Strings.Mid(Info, InStr(Info, "[", CompareMethod.Text) + 1, InStr(Info, "]", CompareMethod.Text) - Strings.Len(angajat) - 3))
        hour_action = Strings.Right(Info, Strings.Len(Info) - InStr(Info, "]", CompareMethod.Text) - 1)

        Dim request As WebRequest = WebRequest.Create("http://www.winsys.ro/winsys.ro/php/add_pontaj.php?ziua='" & ziua & "'&angajat='" & angajat & "'&" & action & "='" & hour_action & "'")
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.  
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.  
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.  
        Dim reader As New StreamReader(dataStream)
        ' Read the content.  
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.  
        Console.WriteLine(responseFromServer)
        ' Clean up the streams and the response.  
        reader.Close()
        response.Close()
    End Sub

End Class
