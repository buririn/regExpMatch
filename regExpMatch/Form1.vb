Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Form1
    Dim submatch() As String = {"", "", "", "", "", "", "", "", "", ""}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkText As String
        Dim rb1 As RadioButton
        Dim rb2 As RadioButton
        Dim ignCaseText As String
        Dim ignCase As Boolean
        Dim regExpEng As String

        '必要な文字列が入力されているかチェック
        If TextBoxRegPattern.Text = "" Then
            TextBoxRegPattern.Text = "入力してください"
            'Exit Sub
        End If

        If TextBoxCheckStrigs.Text = "" Then
            TextBoxCheckStrigs.Text = "入力してください"
            Exit Sub
        End If

        'チェック対象文字列の指定文字数での切りつめ処理を行う
        'チェック対象文字列が入力された有効文字数以下の場合は、
        'チェック対象文字列すべてをマッチ確認対象文字列とする
        '有効文字数が0の場合もチェック対象文字列すべてを対象とする
        If TextBoxCheckStrigs.Text.Length <= NumericUpDown1.Value Or NumericUpDown1.Value = 0 Then
            checkText = TextBoxCheckStrigs.Text
        Else
            checkText = TextBoxCheckStrigs.Text.Substring(0, NumericUpDown1.Value)
        End If

        '入力された正規表現パターン文字列数の表示
        LabelRegPatLength.Text = TextBoxRegPattern.Text.Length & "文字"
        '有効文字列数/入力されたチェック対象文字列数の表示
        LabelCehckStrLength.Text = checkText.Length & "/" & TextBoxCheckStrigs.Text.Length & "文字"

        ignCaseText = ""
        regExpEng = ""

        'どのラジオボタンが選択されているのか取得
        For Each rb1 In GroupBox1.Controls
            If (rb1.Checked) Then
                ignCaseText = rb1.Text
            End If
        Next

        For Each rb2 In GroupBox2.Controls
            If (rb2.Checked) Then
                regExpEng = rb2.Text
            End If
        Next

        'ラジオボタンに従い、正規表現で大文字小文字を区別するかしないか設定する
        Select Case ignCaseText
            Case "しない"
                ignCase = True
            Case "する"
                ignCase = False
        End Select

        Try
            '前回の一致結果欄をクリアする
            Button2_Click(sender, e)

            'ラジオボタンに従い、使用する正規表現エンジンを選んでマッチングを実行する
            Select Case regExpEng
                Case "VBScript"
                    vbs(TextBoxRegPattern.Text, checkText, ignCase)
                Case ".NET"
                    vbdnet(TextBoxRegPattern.Text, checkText, ignCase)
                Case Else
                    vbs(TextBoxRegPattern.Text, checkText, ignCase)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message & "in Button1_Click", "例外発生: Button1_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub vbs(regText, checkText, ignCase)
        'RegExpクラスのMatchメソッドを用いて、正規表現によりサブマッチング文字列を取得する。
        '第1引数: 正規表現パターン	文字列
        '第2引数: 一致確認対象文字列	文字列
        '第3引数: マッチング時に大文字・小文字を区別するかしないかのフラグ
        '戻り値: 文字列の配列。各要素にはマッチした部分文字とサブマッチ文字列最大10が格納される
        Dim objRegExp As New VBScript_RegExp_55.RegExp
        Dim objRegMatches
        Dim objRegSubmatches
        'Dim submatch() As String = {"", "", "", "", "", "", "", "", "", ""}
        Dim i As Long

        Try
            objRegExp.Pattern = regText
            objRegExp.IgnoreCase = ignCase
            objRegExp.Global = False

            'マッチング処理実行
            objRegMatches = objRegExp.Execute(checkText)

            'objRegExp:         RegExpオブジェクト
            'objRegMatches:     マッチコレクション
            'objRegSubmatches:  サブマッチコレクション
            'subMatch: マッチ結果およびサブマッチ結果を格納する文字列型配列
            If objRegMatches.Count > 0 Then
                'マッチした場合の処理。

                'サブマッチ結果にアクセスするため、サブマッチコレクションを作成する
                objRegSubmatches = objRegMatches.Item(0).Submatches
                LabelSubmatchNumbers.Text = "※サブマッチ個数: " & objRegSubmatches.Count

                If objRegSubmatches.Count > 0 Then
                    'サブマッチがあった場合
                    'サブマッチした結果を最大10拾う
                    i = 0
                    Do While (i <= objRegSubmatches.Count - 1 And i < 10)
                        submatch(i) = objRegSubmatches.Item(i)
                        i = i + 1
                    Loop
                Else
                    'サブマッチがなかった場合
                End If

                'マッチ結果を表示する
                TextBoxMatchedText.Text = objRegMatches.Item(0).Value
                'サブマッチ結果を表示する
                setSubMatchText(submatch)
            Else
                'マッチしなかった場合の処理
                TextBoxMatchedText.Text = "アンマッチ"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "例外発生: vbs", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LabelMatchOrNot.Text = "例外発生(VBS RegExp)"
        Finally
            'オブジェクトの開放処理
            objRegExp = Nothing
            objRegMatches = Nothing
            objRegSubmatches = Nothing
        End Try

    End Sub

    Sub vbdnet(regText, checkText, ignCase)
        Dim objRegExp As Regex
        Dim objMatch As Match
        'Dim objMatches As MatchCollection
        'Dim objSubMatches
        'Dim submatch() As String = {"", "", "", "", "", "", "", "", "", ""}
        Dim i As Integer

        Try
            If ignCase = True Then
                '大文字小文字を区別しない場合
                objRegExp = New Regex(regText, RegexOptions.IgnoreCase)

            Else
                '大文字小文字を区別する場合
                objRegExp = New Regex(regText)
            End If

            'objMatches = objRegExp.Matches(checkText)
            'For Each m As Match In objMatches
            '    For i = 0 To m.Groups(0).Captures.Count - 1
            '        submatch(i) = m.Groups(0).Captures(i).Value
            '    Next
            'Next

            '最初のマッチ結果のみ処理したいのでMatchメソッドを利用する
            '全マッチ結果を処理するならMatchesメソッドを利用してMatchコレクションを処理するか
            'Matchメソッドで取得したオブジェクトに対してMatch.NextMatchメソッドを利用すること
            objMatch = objRegExp.Match(checkText)

            If objMatch.Success Then
                '正規表現パターンにマッチした場合

                'サブマッチ結果を最大10個拾い上げる
                'サブマッチ結果はMatchオブジェクトのGroupオブジェクトに格納される
                'ただしGroup0は全体マッチの結果が格納されるのでここのサブマッチ結果は
                'Group1から処理して取得する
                i = 0
                Do While (objMatch.Groups(i + 1).Value <> "" And i < 9)
                    submatch(i) = objMatch.Groups(i + 1).Value
                    i = i + 1
                Loop
                LabelSubmatchNumbers.Text = "※サブマッチ個数: " & objMatch.Groups.Count - 1

                'マッチ結果を表示する
                TextBoxMatchedText.Text = objMatch.Value
                'サブマッチ結果を表示する
                setSubMatchText(submatch)
            Else
                '正規表現パターンにマッチしなかった場合
                TextBoxMatchedText.Text = "アンマッチ"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "例外発生: vbdnet", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LabelMatchOrNot.Text = "例外発生(vbdnet RegExp)"
        Finally
            objRegExp = Nothing
            objMatch = Nothing
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelVBSRegExp.LinkClicked
        LinkLabelVBSRegExp.LinkVisited = True
        System.Diagnostics.Process.Start("http://msdn.microsoft.com/ja-jp/library/cc392020.aspx")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelVBDNRegExp.LinkClicked
        LinkLabelVBDNRegExp.LinkVisited = True
        System.Diagnostics.Process.Start("http://msdn.microsoft.com/ja-jp/library/az24scfc(v=vs.110).aspx")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mutchTextClear()
        subMatchTextClear()
    End Sub

    Private Sub mutchTextClear()
        LabelMatchOrNot.Text = ""
        TextBoxMatchedText.Text = ""
    End Sub

    Private Sub subMatchTextClear()
        TextBoxSubMatch1.Text = ""
        TextBoxSubMatch2.Text = ""
        TextBoxSubMatch3.Text = ""
        TextBoxSubMatch4.Text = ""
        TextBoxSubMatch5.Text = ""
        TextBoxSubMatch6.Text = ""
        TextBoxSubMatch7.Text = ""
        TextBoxSubMatch8.Text = ""
        TextBoxSubMatch9.Text = ""
        TextBoxSubMatch10.Text = ""
        LabelSubmatchNumbers.Text = ""
    End Sub

    Private Sub setSubMatchText(submatch As String())
        TextBoxSubMatch1.Text = submatch(0)
        TextBoxSubMatch2.Text = submatch(1)
        TextBoxSubMatch3.Text = submatch(2)
        TextBoxSubMatch4.Text = submatch(3)
        TextBoxSubMatch5.Text = submatch(4)
        TextBoxSubMatch6.Text = submatch(5)
        TextBoxSubMatch7.Text = submatch(6)
        TextBoxSubMatch8.Text = submatch(7)
        TextBoxSubMatch9.Text = submatch(8)
        TextBoxSubMatch10.Text = submatch(9)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim sumMatch As String

        sumMatch = ""
        For i = 0 To 9
            sumMatch = sumMatch + submatch(i)
        Next

        Clipboard.SetText(sumMatch)

    End Sub

    Private Sub ButtonClrCheckStrings_Click(sender As Object, e As EventArgs) Handles ButtonClrCheckStrings.Click
        TextBoxCheckStrigs.Text = ""
    End Sub
End Class
