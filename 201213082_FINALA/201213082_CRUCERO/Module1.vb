Module Module1
    Public index = 0

    Public Nit(5) As Double
    Public Nombre(5) As String
    Public Tipo(5) As String
    Public Personas(5) As Double
    Public Clase(5) As String
    Public Pago(5) As Double

    Public Const Primerasencilla = 400
    Public Const primeradoble = 700
    Public Const primeracompartida = 350
    Public Const segundasencilla = 375
    Public Const segundadoble = 600
    Public Const segundacompartida = 300

    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()

        index = 0

    End Sub

    Sub limpiar_Entrada()
        Form1.TxtNit.Text = 0
        Form1.TxtNombre.Text = 0
        Form1.Txtpersonas.Text = 0
        Form1.CbxClase.SelectedItem = False
        Form1.CbxTipo.SelectedItem = False
    End Sub

End Module
