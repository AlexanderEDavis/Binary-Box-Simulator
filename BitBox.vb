Imports System.Runtime.InteropServices
Public Class BitBox
    Public bit1 = False
    Public bit2 = False
    Public bit4 = False
    Public bit8 = False
    Public bit16 = False
    Public bit32 = False
    Public bit64 = False
    Public bit128 = False
    Public bit256 = False
    Public binary = ""
    Public denary = 0
    Public privateFontCollection1 As New Drawing.Text.PrivateFontCollection
    Public privateFontCollection2 As New Drawing.Text.PrivateFontCollection
    Public privateFontCollection3 As New Drawing.Text.PrivateFontCollection
    Public FamilyName1 As String
    Public FamilyName2 As String
    Public FamilyName3 As String
    Private Sub BitBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data1 As System.IntPtr = Marshal.AllocCoTaskMem(My.Resources.DSEG7Classic_Regular.Length - 1)

        Marshal.Copy(My.Resources.DSEG7Classic_Regular, 0, data1, My.Resources.DSEG7Classic_Regular.Length)
        privateFontCollection1.AddMemoryFont(data1, My.Resources.DSEG7Classic_Regular.Length)
        Marshal.FreeCoTaskMem(data1)
        Dim fnt1 As Font = New Font(privateFontCollection1.Families(0), 27.75)

        lblDenaryNum.UseCompatibleTextRendering = True
        lblDenaryNum.Font = fnt1
        lblBinaryNum.UseCompatibleTextRendering = True
        lblBinaryNum.Font = fnt1

        Dim data2 As System.IntPtr = Marshal.AllocCoTaskMem(My.Resources.Seven_Segment.Length - 1)
        Marshal.Copy(My.Resources.Seven_Segment, 0, data2, My.Resources.Seven_Segment.Length)
        privateFontCollection2.AddMemoryFont(data2, My.Resources.Seven_Segment.Length)
        Marshal.FreeCoTaskMem(data2)
        Dim fnt2 As Font = New Font(privateFontCollection2.Families(0), 27.75)

        lblDenaryHeading.UseCompatibleTextRendering = True
        lblDenaryHeading.Font = fnt2
        lblBinaryHeading.UseCompatibleTextRendering = True
        lblBinaryHeading.Font = fnt2

        lbl1.UseCompatibleTextRendering = True
        lbl1.Font = fnt2
        lbl2.UseCompatibleTextRendering = True
        lbl2.Font = fnt2
        lbl4.UseCompatibleTextRendering = True
        lbl4.Font = fnt2
        lbl8.UseCompatibleTextRendering = True
        lbl8.Font = fnt2
        lbl16.UseCompatibleTextRendering = True
        lbl16.Font = fnt2
        lbl32.UseCompatibleTextRendering = True
        lbl32.Font = fnt2
        lbl64.UseCompatibleTextRendering = True
        lbl64.Font = fnt2
        lbl128.UseCompatibleTextRendering = True
        lbl128.Font = fnt2
        lbl256.UseCompatibleTextRendering = True
        lbl256.Font = fnt2

        Dim data3 As System.IntPtr = Marshal.AllocCoTaskMem(My.Resources.Unicode_IEC_symbol.Length - 1)
        Marshal.Copy(My.Resources.Unicode_IEC_symbol, 0, data3, My.Resources.Unicode_IEC_symbol.Length)
        privateFontCollection3.AddMemoryFont(data3, My.Resources.Unicode_IEC_symbol.Length)
        Marshal.FreeCoTaskMem(data3)
        Dim fnt3 As Font = New Font(privateFontCollection3.Families(0), 27.75)
        Dim fnt4 As Font = New Font(privateFontCollection3.Families(0), 48)

        swt1.UseCompatibleTextRendering = True
        swt1.Font = fnt3
        swt2.UseCompatibleTextRendering = True
        swt2.Font = fnt3
        swt4.UseCompatibleTextRendering = True
        swt4.Font = fnt3
        swt8.UseCompatibleTextRendering = True
        swt8.Font = fnt3
        swt16.UseCompatibleTextRendering = True
        swt16.Font = fnt3
        swt32.UseCompatibleTextRendering = True
        swt32.Font = fnt3
        swt64.UseCompatibleTextRendering = True
        swt64.Font = fnt3
        swt128.UseCompatibleTextRendering = True
        swt128.Font = fnt3
        swt256.UseCompatibleTextRendering = True
        swt256.Font = fnt3

        btnExit.UseCompatibleTextRendering = True
        btnExit.Font = fnt4

    End Sub

    Private Sub swt1_Click(sender As Object, e As EventArgs) Handles swt1.Click
        If bit1 = False Then
            blb1.ForeColor = System.Drawing.Color.Yellow
            bit1 = True
            updateNumber()
        Else
            blb1.ForeColor = System.Drawing.Color.White
            bit1 = False
            updateNumber()
        End If
    End Sub

    Public Sub updateNumber()
        denary = 0
        binary = ""
        If bit256 Then
            denary = denary + 256
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit128 Then
            denary = denary + 128
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit64 Then
            denary = denary + 64
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit32 Then
            denary = denary + 32
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit16 Then
            denary = denary + 16
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit8 Then
            denary = denary + 8
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit4 Then
            denary = denary + 4
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit2 Then
            denary = denary + 2
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        If bit1 Then
            denary = denary + 1
            binary = binary + "1"
        Else
            binary = binary + "0"
        End If
        lblDenaryNum.Text = denary
        lblBinaryNum.Text = binary
    End Sub

    Private Sub swt2_Click(sender As Object, e As EventArgs) Handles swt2.Click
        If bit2 = False Then
            blb2.ForeColor = System.Drawing.Color.Yellow
            bit2 = True
            updateNumber()
        Else
            blb2.ForeColor = System.Drawing.Color.White
            bit2 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt4_Click(sender As Object, e As EventArgs) Handles swt4.Click
        If bit4 = False Then
            blb4.ForeColor = System.Drawing.Color.Yellow
            bit4 = True
            updateNumber()
        Else
            blb4.ForeColor = System.Drawing.Color.White
            bit4 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt8_Click(sender As Object, e As EventArgs) Handles swt8.Click
        If bit8 = False Then
            blb8.ForeColor = System.Drawing.Color.Yellow
            bit8 = True
            updateNumber()
        Else
            blb8.ForeColor = System.Drawing.Color.White
            bit8 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt16_Click(sender As Object, e As EventArgs) Handles swt16.Click
        If bit16 = False Then
            blb16.ForeColor = System.Drawing.Color.Yellow
            bit16 = True
            updateNumber()
        Else
            blb16.ForeColor = System.Drawing.Color.White
            bit16 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt32_Click(sender As Object, e As EventArgs) Handles swt32.Click
        If bit32 = False Then
            blb32.ForeColor = System.Drawing.Color.Yellow
            bit32 = True
            updateNumber()
        Else
            blb32.ForeColor = System.Drawing.Color.White
            bit32 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt64_Click(sender As Object, e As EventArgs) Handles swt64.Click
        If bit64 = False Then
            blb64.ForeColor = System.Drawing.Color.Yellow
            bit64 = True
            updateNumber()
        Else
            blb64.ForeColor = System.Drawing.Color.White
            bit64 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt128_Click(sender As Object, e As EventArgs) Handles swt128.Click
        If bit128 = False Then
            blb128.ForeColor = System.Drawing.Color.Yellow
            bit128 = True
            updateNumber()
        Else
            blb128.ForeColor = System.Drawing.Color.White
            bit128 = False
            updateNumber()
        End If
    End Sub

    Private Sub swt256_Click(sender As Object, e As EventArgs) Handles swt256.Click
        If bit256 = False Then
            blb256.ForeColor = System.Drawing.Color.Yellow
            bit256 = True
            updateNumber()
        Else
            blb256.ForeColor = System.Drawing.Color.White
            bit256 = False
            updateNumber()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutBox.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
