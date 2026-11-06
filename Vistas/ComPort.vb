Public Class ComPort
    Private Sub ComPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        LblPuertoActual.Text = My.Settings.NombrePuerto
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CmbPuertos.Items.Add(sp)
        Next
    End Sub

    Private Sub BtnAceptarPuerto_Click(sender As Object, e As EventArgs) Handles BtnAceptarPuerto.Click
        If CmbPuertos.Text <> "" Then
            If MessageBox.Show("¿Confirmar la modificacion del puerto de entrada?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Settings.NombrePuerto = CmbPuertos.Text
                My.Settings.Save()
                My.Settings.Reload()
                If Form1.SerialPortWeight.IsOpen Then

                End If
            End If
        End If
    End Sub
End Class