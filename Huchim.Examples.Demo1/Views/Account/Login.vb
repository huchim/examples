''' <summary>
''' Realiza las validaciones de usuario y contraseña en la aplicación.
''' </summary>
''' <remarks>Este formulario debe establecer el resultado de la validación en la variable DialogResult</remarks>
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Este formulario fue procesado de manera correcta.
        Me.DialogResult = Windows.Forms.DialogResult.OK

        ' Este formulario se cerrará, cediendo el control al evento declarado en Program.Main
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' El formulario tiene errores, no se abrirá el formulario principal.
        Me.DialogResult = Windows.Forms.DialogResult.Abort

        ' Este formulario se cerrará, cediendo el control al evento declarado en Program.Main
        Me.Close()
    End Sub
End Class