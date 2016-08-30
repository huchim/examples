''' <summary>
''' Este módulo no es creado automáticamente por Visual Studio. Una vez creado es necesario ir a las propiedades del proyecto
''' y deshabilitar "Habilitar marco de trabajo de la aplicación" para poder elegir en la lista de Objeto de Inicio este módulo.
''' </summary>
''' <remarks></remarks>
Module Program
    

    Public Sub Main()
        ' Inicializo la configuración de los estilo.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Creo una nueva instancia del formulario de validación y lo muestro hasta esperar que el formulario se cierre.
        Dim Login As New Login

        ' La idea es tratar el formulario como un dialogo donde el resultado deberá ser Ok.
        ' Ver en el formulario Login como establecer y cerrar el formulario.
        If (Login.ShowDialog() = DialogResult.OK) Then
            ' La validación es correcta.
            Application.Run(New MainForm)
        End If
    End Sub
End Module
