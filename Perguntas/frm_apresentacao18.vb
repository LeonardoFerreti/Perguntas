﻿Public Class frm_apresentacao18


    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao17 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        ' Me.Hide()

        Dim frm As frm_Perguntas_alteracao_verbo = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_alteracao_verbo Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_alteracao_verbo
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub


End Class