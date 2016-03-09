Public Class Form1

    Dim showidth As Short
    Dim sholenght As Short
    Dim shopannels As Short
    Dim inttotalcost As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbofencetype.Items.Add("Cheap £35 a meter")
        cbofencetype.Items.Add("Expensive £45 a meter")

        txtlabour.Text = 150
        txtlabour.Enabled = False

        txtpannels.Enabled = False
        txttotalcost.Enabled = False
    End Sub

    Private Sub bntclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        Me.Close()
    End Sub

    Private Sub bntclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclear.Click
        Call clearcontrols()
    End Sub

    Private Sub clearcontrols()
        txtlength.Text = ""
        txtwidth.Text = ""
        cbofencetype.Items.Clear()
        txtpannels.Text = ""

    End Sub

    Private Sub bntcaculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntcaculate.Click

        If txtlength.Text = "" Then
            Exit Sub
        ElseIf txtwidth.Text = "" Then
            Exit Sub
        End If

        sholenght = Val(txtlength.Text)
        showidth = Val(txtwidth.Text)

        If radrectangle.Checked = True Then
            shopannels = ((sholenght * 2) + showidth) / 2
        Else
            shopannels = ((sholenght * 3) / 2)
        End If

        txtpannels.Text = shopannels

        If cbofencetype.Text = ("Cheap £35 a meter") Then
            inttotalcost = (shopannels * 35) + 150
        Else If cbofencetype.Text = ("Expensive £45 a meter") then 
            inttotalcost = (shopannels * 45) + 150
        End If
        txttotalcost.Text = inttotalcost

    End Sub


    Private Sub radsquare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radsquare.CheckedChanged
        Me.txtwidth.Enabled = False
    End Sub

    Private Sub radrectangle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radrectangle.CheckedChanged
        Me.txtwidth.Enabled = True

    End Sub

    Private Sub bnthelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnthelp.Click

        Form2.Show()
    End Sub

    Private Sub txtlength_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlength.TextChanged

    End Sub
End Class
