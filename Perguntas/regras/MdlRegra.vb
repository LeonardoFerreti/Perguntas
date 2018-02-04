﻿Module MdlRegra

    Public NUMERO_MAXIMO_TENTATIVAS_COM_PERDA As Integer = 2

    Public PONTUACAO_TELA_ALTERAR_VERBOS As Integer = 10
    Public PONTUACAO_TELA_ARRASTAR_PALAVRAS As Integer = 20
    Public PONTUACAO_TELA_ARRASTAR_COMPLETAR As Integer = 10
    Public PONTUACAO_TELA_COMBINACOES_CONTRACOES As Integer = 14
    Public PONTUACAO_TELA_CONTRACAO_OBLIQUO As Integer = 4
    Public PONTUACAO_TELA_FRASES As Integer = 10
    Public PONTUACAO_TELA_MUSICA As Integer = 12
    Public PONTUACAO_TELA_REESCREVER_FRASES As Integer = 10
    Public PONTUACAO_TELA_RESPONDER_PERGUNTAS As Integer = 10
    'A soma total dá 100(excelente)
    'as validacoes das telas vao diminuindo a pontuaçao total

    ''variavel para armazenar o numero de tentativas de validacao de cada tela
    Public TENTATIVAS_TELA_ALTERAR_VERBOS As Integer = 0
    Public TENTATIVAS_TELA_ARRASTAR_PALAVRAS As Integer = 0
    Public TENTATIVAS_TELA_ARRASTAR_COMPLETAR As Integer = 0
    Public TENTATIVAS_TELA_COMBINACOES_CONTRACOES As Integer = 0
    Public TENTATIVAS_TELA_CONTRACAO_OBLIQUO As Integer = 0
    Public TENTATIVAS_TELA_FRASES As Integer = 0
    Public TENTATIVAS_TELA_MUSICA As Integer = 0
    Public TENTATIVAS_TELA_REESCREVER_FRASES As Integer = 0
    Public TENTATIVAS_TELA_RESPONDER_PERGUNTAS As Integer = 0

    ''VARIAVEIS QUE DEFINEM QUANTO SE DEVE DIMINUIR DE CADA QUESTAO A CADA VALIDAÇAO ERRADA
    Public DIMINUIR_ERRO_TELA_ALTERAR_VERBOS As Integer = 1
    Public DIMINUIR_ERRO_TELA_ARRASTAR_PALAVRAS As Integer = 2
    Public DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR As Integer = 1
    Public DIMINUIR_ERRO_TELA_COMBINACOES_CONTRACOES As Integer = 1
    Public DIMINUIR_ERRO_TELA_CONTRACAO_OBLIQUO As Integer = 0.5
    Public DIMINUIR_ERRO_TELA_FRASES As Integer = 1
    Public DIMINUIR_ERRO_TELA_MUSICA As Integer = 2
    Public DIMINUIR_ERRO_TELA_REESCREVER_FRASES As Integer = 1
    Public DIMINUIR_ERRO_TELA_RESPONDER_PERGUNTAS As Integer = 1


End Module