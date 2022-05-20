Public Class Form1
    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If index < 5 Then
            Nit(index) = TxtNit.Text
            Nombre(index) = TxtNombre.Text
            Personas(index) = Txtpersonas.Text
            Tipo(index) = CbxTipo.SelectedItem
            Clase(index) = CbxClase.SelectedItem
            Pago(index) = Pago(index)

            If CbxTipo.SelectedItem = "Sencilla" And CbxClase.SelectedItem = "Primera Clase" Then
                Pago(index) = Primerasencilla * Personas(index)
            ElseIf CbxTipo.SelectedItem = "Sencilla" And CbxClase.SelectedItem = "Segunda Clase" Then
                Pago(index) = segundasencilla * Personas(index)
            End If

            If CbxTipo.SelectedItem = "Doble" And CbxClase.SelectedItem = "Primera Clase" Then
                Pago(index) = primeradoble * Personas(index)
            ElseIf CbxTipo.SelectedItem = "Doble" And CbxClase.SelectedItem = "Segunda Clase" Then
                Pago(index) = segundadoble * Personas(index)
            End If

            If CbxTipo.SelectedItem = "Compartida" And CbxClase.SelectedItem = "Primera Clase" Then
                Pago(index) = primeracompartida * Personas(index)
            ElseIf CbxTipo.SelectedItem = "Compartida" And CbxClase.SelectedItem = "Segunda Clase" Then
                Pago(index) = segundacompartida * Personas(index)
            End If

            DataGridView1.Rows.Add(Nit(index), Nombre(index), Tipo(index), Personas(index), Clase(index), Pago(index))

            index = 0 + 1
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        DataGridView1.Rows.Add(Nit(index), Nombre(index), Tipo(index), Personas(index), Clase(index), Pago(index))
        index = 0 + 1
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        index = 0
        While (index <= 2) And Not (existe)
            If (Nit(index) = Val(TxtNit.Text)) Then
                existe = True
            Else
                index = index + 1
            End If
        End While
        If (existe) Then
            MsgBox("Nit encontrado exitosamente")
            TxtNit.Text = Nit(index)
            TxtNombre.Text = Nombre(index)
            Txtpersonas.Text = Personas(index)
            CbxTipo.SelectedItem = Tipo(index)
            CbxClase.SelectedItem = Clase(index)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Nit(index), Nombre(index), Tipo(index), Personas(index), Clase(index), Pago(index))
        Else
            MsgBox("Número de Nit no encontado")
            TxtConsulta.Focus()
        End If
    End Sub

    Private Sub OrdenarDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendenteToolStripMenuItem.Click

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar_Entrada()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
End Class
