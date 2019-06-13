Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As New MySqlConnection
    Dim comandos, comandos2 As New MySqlCommand
    Dim sql, sql2 As String

    Dim seguro As String
    Dim sex As String
    Dim tipseg As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=bdseguros"
            conexion.Open()
            MsgBox("Conectado!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        naseg.Visible = False
        fedpa.Visible = False
        inseg.Visible = False
        assa.Visible = False

        viviimage.Visible = False
        autoimage.Visible = False
        vidaimage.Visible = False

    End Sub


    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Try

            If Me.ValidateChildren And cedula.Text <> String.Empty And nombre.Text <> String.Empty And direccion.Text <> String.Empty And telefono.Text <> String.Empty And tipoempresa.Text <> String.Empty And vivienda.Checked Or automovil.Checked Or vida.Checked Then

                sql = "INSERT INTO tabpoliza (cedula,nombre,sexo,direccion,contacto,tipcomp) VALUES(@cedula,@nombre,@sexo,@direccion,@contacto,@tipcomp)"

                comandos = New MySqlCommand(sql, conexion)

                'Insertando valores en la base de datos'
                comandos.Parameters.AddWithValue("@cedula", cedula.Text)
                comandos.Parameters.AddWithValue("@nombre", nombre.Text)
                comandos.Parameters.AddWithValue("@sexo", sex)
                comandos.Parameters.AddWithValue("@direccion", direccion.Text)
                comandos.Parameters.AddWithValue("@contacto", telefono.Text)
                comandos.Parameters.AddWithValue("@tipcomp", seguro)


                If vivienda.Checked Then
                    tipseg = "Vivienda"
                    sql2 = "INSERT INTO cliente_tiposeg (cedula,tiposeg) VALUES(@cedula,@tipseg)"
                    comandos2 = New MySqlCommand(sql2, conexion)
                    comandos2.Parameters.AddWithValue("@cedula", cedula.Text)
                    comandos2.Parameters.AddWithValue("@tipseg", tipseg)
                    comandos2.ExecuteNonQuery()

                End If


                If automovil.Checked Then
                    tipseg = "Auto"
                    sql2 = "INSERT INTO cliente_tiposeg (cedula,tiposeg) VALUES(@cedula,@tipseg)"
                    comandos2 = New MySqlCommand(sql2, conexion)
                    comandos2.Parameters.AddWithValue("@cedula", cedula.Text)
                    comandos2.Parameters.AddWithValue("@tipseg", tipseg)
                    comandos2.ExecuteNonQuery()
                End If

                If vida.Checked Then
                    tipseg = "Vida"
                    sql2 = "INSERT INTO cliente_tiposeg (cedula,tiposeg) VALUES(@cedula,@tipseg)"
                    comandos2 = New MySqlCommand(sql2, conexion)
                    comandos2.Parameters.AddWithValue("@cedula", cedula.Text)
                    comandos2.Parameters.AddWithValue("@tipseg", tipseg)
                    comandos2.ExecuteNonQuery()
                End If





                comandos.ExecuteNonQuery()
                    MsgBox("Datos Guardados!!")


                    MessageBox.Show("Datos registrados correctamente", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Form3.Show()
                Else
                    MessageBox.Show("Llene todos los campos", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If



        Catch ex As Exception

            MsgBox("ERROR DE CONEXION A BASE DE DATOS = " & ex.Message)

        End Try


    End Sub

    Private Sub tipoempresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipoempresa.SelectedIndexChanged
        If tipoempresa.SelectedIndex = 0 Then

            naseg.Visible = True
            fedpa.Visible = False
            inseg.Visible = False
            assa.Visible = False

            seguro = "Nacional de Seguros"

        ElseIf tipoempresa.SelectedIndex = 1 Then
            naseg.Visible = False
            fedpa.Visible = True
            inseg.Visible = False
            assa.Visible = False

            seguro = "Fedpa"

        ElseIf tipoempresa.SelectedIndex = 2 Then
            naseg.Visible = False
            fedpa.Visible = False
            inseg.Visible = True
            assa.Visible = False

            seguro = "Internacional de Seguros"

        ElseIf tipoempresa.SelectedIndex = 3 Then
            naseg.Visible = False
            fedpa.Visible = False
            inseg.Visible = False
            assa.Visible = True

            seguro = "Assa"


        End If



    End Sub

    Private Sub masculino_CheckedChanged(sender As Object, e As EventArgs) Handles masculino.CheckedChanged

        If masculino.Checked Then
            sex = "Masculino"
        End If

    End Sub

    Private Sub femenino_CheckedChanged(sender As Object, e As EventArgs) Handles femenino.CheckedChanged

        If femenino.Checked Then
            sex = "Femenino"
        End If

    End Sub


    Private Sub vivienda_CheckedChanged_1(sender As Object, e As EventArgs) Handles vivienda.CheckedChanged
        If vivienda.Checked Then
            viviimage.Visible = True
        Else
            viviimage.Visible = False

        End If
    End Sub

    Private Sub automovil_CheckedChanged_1(sender As Object, e As EventArgs) Handles automovil.CheckedChanged
        If automovil.Checked Then
            autoimage.Visible = True
        Else
            autoimage.Visible = False

        End If
    End Sub

    Private Sub vida_CheckedChanged_1(sender As Object, e As EventArgs) Handles vida.CheckedChanged
        If vida.Checked Then
            vidaimage.Visible = True
        Else

            vidaimage.Visible = False

        End If
    End Sub


    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        cedula.Clear()
        nombre.Clear()
        masculino.Checked = False
        femenino.Checked = False
        direccion.Clear()
        telefono.Clear()
        tipoempresa.Text = ""
        vivienda.Checked = False
        automovil.Checked = False
        vida.Checked = False

        naseg.Visible = False
        fedpa.Visible = False
        inseg.Visible = False
        assa.Visible = False

        viviimage.Visible = False
        autoimage.Visible = False
        vidaimage.Visible = False


    End Sub


    Private Sub cedula_Validating(sender As Object, e As CancelEventArgs) Handles cedula.Validating
        validar(cedula)

    End Sub


    Private Sub nombre_Validating(sender As Object, e As CancelEventArgs) Handles nombre.Validating
        validar(nombre)
    End Sub

    Private Sub direccion_Validating(sender As Object, e As CancelEventArgs) Handles direccion.Validating
        validar(direccion)
    End Sub

    Private Sub telefono_Validating(sender As Object, e As CancelEventArgs) Handles telefono.Validating
        validar(telefono)
    End Sub


    Public Sub validar(ByVal ParamArray caja() As TextBox)
        For i = 0 To caja.Length - 1
            If caja(i).Text.Length = 0 Then
                ErrorProvider.SetError(caja(i), "Debe llenar este campo!!")
            Else
                ErrorProvider.SetError(caja(i), "")
            End If
        Next
    End Sub


End Class
