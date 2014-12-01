<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxRegPattern = New System.Windows.Forms.TextBox()
        Me.TextBoxCheckStrigs = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelRegPattern = New System.Windows.Forms.Label()
        Me.LabelCheckStrings = New System.Windows.Forms.Label()
        Me.LinkLabelVBSRegExp = New System.Windows.Forms.LinkLabel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LabelEffectiveStringsLength = New System.Windows.Forms.Label()
        Me.LabelMatchOrNot = New System.Windows.Forms.Label()
        Me.LabelCheckResult = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.LinkLabelVBDNRegExp = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxMatchedText = New System.Windows.Forms.TextBox()
        Me.LabelCehckStrLength = New System.Windows.Forms.Label()
        Me.LabelRegPatLength = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch1 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch1 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut1 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch2 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch2 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut2 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch3 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch3 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut3 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch5 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch5 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut5 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch4 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch4 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut4 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch10 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch10 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut10 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch9 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch9 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut9 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch8 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch8 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut8 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch7 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch7 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut7 = New System.Windows.Forms.Label()
        Me.TextBoxSubMatch6 = New System.Windows.Forms.TextBox()
        Me.LabelSubMatch6 = New System.Windows.Forms.Label()
        Me.LabelSubMatchOut6 = New System.Windows.Forms.Label()
        Me.LabelSubmatchNumbers = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonClrCheckStrings = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxRegPattern
        '
        Me.TextBoxRegPattern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRegPattern.Location = New System.Drawing.Point(117, 12)
        Me.TextBoxRegPattern.Name = "TextBoxRegPattern"
        Me.TextBoxRegPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxRegPattern.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxRegPattern.TabIndex = 0
        Me.TextBoxRegPattern.WordWrap = False
        '
        'TextBoxCheckStrigs
        '
        Me.TextBoxCheckStrigs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCheckStrigs.Location = New System.Drawing.Point(117, 39)
        Me.TextBoxCheckStrigs.Multiline = True
        Me.TextBoxCheckStrigs.Name = "TextBoxCheckStrigs"
        Me.TextBoxCheckStrigs.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxCheckStrigs.TabIndex = 1
        Me.TextBoxCheckStrigs.WordWrap = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelRegPattern
        '
        Me.LabelRegPattern.AutoSize = True
        Me.LabelRegPattern.Location = New System.Drawing.Point(3, 12)
        Me.LabelRegPattern.Name = "LabelRegPattern"
        Me.LabelRegPattern.Size = New System.Drawing.Size(53, 12)
        Me.LabelRegPattern.TabIndex = 3
        Me.LabelRegPattern.Text = "正規表現"
        '
        'LabelCheckStrings
        '
        Me.LabelCheckStrings.AutoSize = True
        Me.LabelCheckStrings.Location = New System.Drawing.Point(3, 39)
        Me.LabelCheckStrings.Name = "LabelCheckStrings"
        Me.LabelCheckStrings.Size = New System.Drawing.Size(72, 12)
        Me.LabelCheckStrings.TabIndex = 4
        Me.LabelCheckStrings.Text = "チェック文字列"
        '
        'LinkLabelVBSRegExp
        '
        Me.LinkLabelVBSRegExp.AutoSize = True
        Me.LinkLabelVBSRegExp.Location = New System.Drawing.Point(10, 472)
        Me.LinkLabelVBSRegExp.Name = "LinkLabelVBSRegExp"
        Me.LinkLabelVBSRegExp.Size = New System.Drawing.Size(99, 12)
        Me.LinkLabelVBSRegExp.TabIndex = 6
        Me.LinkLabelVBSRegExp.TabStop = True
        Me.LinkLabelVBSRegExp.Text = "VBScript正規表現"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 15)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "しない"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 33)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 15)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "する"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 402)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 53)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "大小文字区別"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(172, 377)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {7000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(45, 19)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelEffectiveStringsLength
        '
        Me.LabelEffectiveStringsLength.AutoSize = True
        Me.LabelEffectiveStringsLength.Location = New System.Drawing.Point(109, 362)
        Me.LabelEffectiveStringsLength.Name = "LabelEffectiveStringsLength"
        Me.LabelEffectiveStringsLength.Size = New System.Drawing.Size(108, 12)
        Me.LabelEffectiveStringsLength.TabIndex = 11
        Me.LabelEffectiveStringsLength.Text = "チェック対象文字列数"
        '
        'LabelMatchOrNot
        '
        Me.LabelMatchOrNot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMatchOrNot.AutoSize = True
        Me.LabelMatchOrNot.Font = New System.Drawing.Font("MS UI Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMatchOrNot.Location = New System.Drawing.Point(3, 80)
        Me.LabelMatchOrNot.Name = "LabelMatchOrNot"
        Me.LabelMatchOrNot.Size = New System.Drawing.Size(0, 9)
        Me.LabelMatchOrNot.TabIndex = 12
        Me.LabelMatchOrNot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCheckResult
        '
        Me.LabelCheckResult.AutoSize = True
        Me.LabelCheckResult.Location = New System.Drawing.Point(3, 66)
        Me.LabelCheckResult.Name = "LabelCheckResult"
        Me.LabelCheckResult.Size = New System.Drawing.Size(54, 12)
        Me.LabelCheckResult.TabIndex = 13
        Me.LabelCheckResult.Text = "マッチ結果"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(117, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(98, 53)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "正規表現エンジン"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(5, 15)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(65, 15)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "VBScript"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(5, 33)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(44, 15)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = ".NET"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'LinkLabelVBDNRegExp
        '
        Me.LinkLabelVBDNRegExp.AutoSize = True
        Me.LinkLabelVBDNRegExp.Location = New System.Drawing.Point(10, 495)
        Me.LinkLabelVBDNRegExp.Name = "LinkLabelVBDNRegExp"
        Me.LinkLabelVBDNRegExp.Size = New System.Drawing.Size(77, 12)
        Me.LinkLabelVBDNRegExp.TabIndex = 14
        Me.LinkLabelVBDNRegExp.TabStop = True
        Me.LinkLabelVBDNRegExp.Text = ".NET正規表現"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 493)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "結果クリア"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxMatchedText
        '
        Me.TextBoxMatchedText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMatchedText.Location = New System.Drawing.Point(117, 66)
        Me.TextBoxMatchedText.Name = "TextBoxMatchedText"
        Me.TextBoxMatchedText.ReadOnly = True
        Me.TextBoxMatchedText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxMatchedText.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxMatchedText.TabIndex = 16
        Me.TextBoxMatchedText.WordWrap = False
        '
        'LabelCehckStrLength
        '
        Me.LabelCehckStrLength.Font = New System.Drawing.Font("MS UI Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelCehckStrLength.Location = New System.Drawing.Point(3, 51)
        Me.LabelCehckStrLength.Name = "LabelCehckStrLength"
        Me.LabelCehckStrLength.Size = New System.Drawing.Size(79, 12)
        Me.LabelCehckStrLength.TabIndex = 17
        Me.LabelCehckStrLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelRegPatLength
        '
        Me.LabelRegPatLength.Font = New System.Drawing.Font("MS UI Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelRegPatLength.Location = New System.Drawing.Point(3, 24)
        Me.LabelRegPatLength.Name = "LabelRegPatLength"
        Me.LabelRegPatLength.Size = New System.Drawing.Size(38, 12)
        Me.LabelRegPatLength.TabIndex = 18
        Me.LabelRegPatLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSubMatch1
        '
        Me.TextBoxSubMatch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch1.Location = New System.Drawing.Point(117, 97)
        Me.TextBoxSubMatch1.Name = "TextBoxSubMatch1"
        Me.TextBoxSubMatch1.ReadOnly = True
        Me.TextBoxSubMatch1.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch1.TabIndex = 21
        '
        'LabelSubMatch1
        '
        Me.LabelSubMatch1.AutoSize = True
        Me.LabelSubMatch1.Location = New System.Drawing.Point(3, 102)
        Me.LabelSubMatch1.Name = "LabelSubMatch1"
        Me.LabelSubMatch1.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch1.TabIndex = 20
        Me.LabelSubMatch1.Text = "サブマッチ1結果"
        '
        'LabelSubMatchOut1
        '
        Me.LabelSubMatchOut1.AutoSize = True
        Me.LabelSubMatchOut1.Location = New System.Drawing.Point(76, 101)
        Me.LabelSubMatchOut1.Name = "LabelSubMatchOut1"
        Me.LabelSubMatchOut1.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut1.TabIndex = 19
        Me.LabelSubMatchOut1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch2
        '
        Me.TextBoxSubMatch2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch2.Location = New System.Drawing.Point(117, 123)
        Me.TextBoxSubMatch2.Name = "TextBoxSubMatch2"
        Me.TextBoxSubMatch2.ReadOnly = True
        Me.TextBoxSubMatch2.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch2.TabIndex = 24
        '
        'LabelSubMatch2
        '
        Me.LabelSubMatch2.AutoSize = True
        Me.LabelSubMatch2.Location = New System.Drawing.Point(3, 128)
        Me.LabelSubMatch2.Name = "LabelSubMatch2"
        Me.LabelSubMatch2.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch2.TabIndex = 23
        Me.LabelSubMatch2.Text = "サブマッチ2結果"
        '
        'LabelSubMatchOut2
        '
        Me.LabelSubMatchOut2.AutoSize = True
        Me.LabelSubMatchOut2.Location = New System.Drawing.Point(76, 127)
        Me.LabelSubMatchOut2.Name = "LabelSubMatchOut2"
        Me.LabelSubMatchOut2.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut2.TabIndex = 22
        Me.LabelSubMatchOut2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch3
        '
        Me.TextBoxSubMatch3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch3.Location = New System.Drawing.Point(117, 149)
        Me.TextBoxSubMatch3.Name = "TextBoxSubMatch3"
        Me.TextBoxSubMatch3.ReadOnly = True
        Me.TextBoxSubMatch3.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch3.TabIndex = 27
        '
        'LabelSubMatch3
        '
        Me.LabelSubMatch3.AutoSize = True
        Me.LabelSubMatch3.Location = New System.Drawing.Point(3, 154)
        Me.LabelSubMatch3.Name = "LabelSubMatch3"
        Me.LabelSubMatch3.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch3.TabIndex = 26
        Me.LabelSubMatch3.Text = "サブマッチ3結果"
        '
        'LabelSubMatchOut3
        '
        Me.LabelSubMatchOut3.AutoSize = True
        Me.LabelSubMatchOut3.Location = New System.Drawing.Point(76, 153)
        Me.LabelSubMatchOut3.Name = "LabelSubMatchOut3"
        Me.LabelSubMatchOut3.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut3.TabIndex = 25
        Me.LabelSubMatchOut3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch5
        '
        Me.TextBoxSubMatch5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch5.Location = New System.Drawing.Point(117, 201)
        Me.TextBoxSubMatch5.Name = "TextBoxSubMatch5"
        Me.TextBoxSubMatch5.ReadOnly = True
        Me.TextBoxSubMatch5.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch5.TabIndex = 33
        '
        'LabelSubMatch5
        '
        Me.LabelSubMatch5.AutoSize = True
        Me.LabelSubMatch5.Location = New System.Drawing.Point(3, 206)
        Me.LabelSubMatch5.Name = "LabelSubMatch5"
        Me.LabelSubMatch5.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch5.TabIndex = 32
        Me.LabelSubMatch5.Text = "サブマッチ5結果"
        '
        'LabelSubMatchOut5
        '
        Me.LabelSubMatchOut5.AutoSize = True
        Me.LabelSubMatchOut5.Location = New System.Drawing.Point(76, 205)
        Me.LabelSubMatchOut5.Name = "LabelSubMatchOut5"
        Me.LabelSubMatchOut5.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut5.TabIndex = 31
        Me.LabelSubMatchOut5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch4
        '
        Me.TextBoxSubMatch4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch4.Location = New System.Drawing.Point(117, 175)
        Me.TextBoxSubMatch4.Name = "TextBoxSubMatch4"
        Me.TextBoxSubMatch4.ReadOnly = True
        Me.TextBoxSubMatch4.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch4.TabIndex = 30
        '
        'LabelSubMatch4
        '
        Me.LabelSubMatch4.AutoSize = True
        Me.LabelSubMatch4.Location = New System.Drawing.Point(3, 180)
        Me.LabelSubMatch4.Name = "LabelSubMatch4"
        Me.LabelSubMatch4.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch4.TabIndex = 29
        Me.LabelSubMatch4.Text = "サブマッチ4結果"
        '
        'LabelSubMatchOut4
        '
        Me.LabelSubMatchOut4.AutoSize = True
        Me.LabelSubMatchOut4.Location = New System.Drawing.Point(76, 179)
        Me.LabelSubMatchOut4.Name = "LabelSubMatchOut4"
        Me.LabelSubMatchOut4.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut4.TabIndex = 28
        Me.LabelSubMatchOut4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch10
        '
        Me.TextBoxSubMatch10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch10.Location = New System.Drawing.Point(117, 331)
        Me.TextBoxSubMatch10.Name = "TextBoxSubMatch10"
        Me.TextBoxSubMatch10.ReadOnly = True
        Me.TextBoxSubMatch10.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch10.TabIndex = 48
        '
        'LabelSubMatch10
        '
        Me.LabelSubMatch10.AutoSize = True
        Me.LabelSubMatch10.Location = New System.Drawing.Point(3, 336)
        Me.LabelSubMatch10.Name = "LabelSubMatch10"
        Me.LabelSubMatch10.Size = New System.Drawing.Size(85, 12)
        Me.LabelSubMatch10.TabIndex = 47
        Me.LabelSubMatch10.Text = "サブマッチ10結果"
        '
        'LabelSubMatchOut10
        '
        Me.LabelSubMatchOut10.AutoSize = True
        Me.LabelSubMatchOut10.Location = New System.Drawing.Point(76, 335)
        Me.LabelSubMatchOut10.Name = "LabelSubMatchOut10"
        Me.LabelSubMatchOut10.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut10.TabIndex = 46
        Me.LabelSubMatchOut10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch9
        '
        Me.TextBoxSubMatch9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch9.Location = New System.Drawing.Point(117, 305)
        Me.TextBoxSubMatch9.Name = "TextBoxSubMatch9"
        Me.TextBoxSubMatch9.ReadOnly = True
        Me.TextBoxSubMatch9.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch9.TabIndex = 45
        '
        'LabelSubMatch9
        '
        Me.LabelSubMatch9.AutoSize = True
        Me.LabelSubMatch9.Location = New System.Drawing.Point(3, 310)
        Me.LabelSubMatch9.Name = "LabelSubMatch9"
        Me.LabelSubMatch9.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch9.TabIndex = 44
        Me.LabelSubMatch9.Text = "サブマッチ9結果"
        '
        'LabelSubMatchOut9
        '
        Me.LabelSubMatchOut9.AutoSize = True
        Me.LabelSubMatchOut9.Location = New System.Drawing.Point(76, 309)
        Me.LabelSubMatchOut9.Name = "LabelSubMatchOut9"
        Me.LabelSubMatchOut9.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut9.TabIndex = 43
        Me.LabelSubMatchOut9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch8
        '
        Me.TextBoxSubMatch8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch8.Location = New System.Drawing.Point(117, 279)
        Me.TextBoxSubMatch8.Name = "TextBoxSubMatch8"
        Me.TextBoxSubMatch8.ReadOnly = True
        Me.TextBoxSubMatch8.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch8.TabIndex = 42
        '
        'LabelSubMatch8
        '
        Me.LabelSubMatch8.AutoSize = True
        Me.LabelSubMatch8.Location = New System.Drawing.Point(3, 284)
        Me.LabelSubMatch8.Name = "LabelSubMatch8"
        Me.LabelSubMatch8.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch8.TabIndex = 41
        Me.LabelSubMatch8.Text = "サブマッチ8結果"
        '
        'LabelSubMatchOut8
        '
        Me.LabelSubMatchOut8.AutoSize = True
        Me.LabelSubMatchOut8.Location = New System.Drawing.Point(76, 283)
        Me.LabelSubMatchOut8.Name = "LabelSubMatchOut8"
        Me.LabelSubMatchOut8.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut8.TabIndex = 40
        Me.LabelSubMatchOut8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch7
        '
        Me.TextBoxSubMatch7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch7.Location = New System.Drawing.Point(117, 253)
        Me.TextBoxSubMatch7.Name = "TextBoxSubMatch7"
        Me.TextBoxSubMatch7.ReadOnly = True
        Me.TextBoxSubMatch7.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch7.TabIndex = 39
        '
        'LabelSubMatch7
        '
        Me.LabelSubMatch7.AutoSize = True
        Me.LabelSubMatch7.Location = New System.Drawing.Point(3, 258)
        Me.LabelSubMatch7.Name = "LabelSubMatch7"
        Me.LabelSubMatch7.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch7.TabIndex = 38
        Me.LabelSubMatch7.Text = "サブマッチ7結果"
        '
        'LabelSubMatchOut7
        '
        Me.LabelSubMatchOut7.AutoSize = True
        Me.LabelSubMatchOut7.Location = New System.Drawing.Point(76, 257)
        Me.LabelSubMatchOut7.Name = "LabelSubMatchOut7"
        Me.LabelSubMatchOut7.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut7.TabIndex = 37
        Me.LabelSubMatchOut7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSubMatch6
        '
        Me.TextBoxSubMatch6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubMatch6.Location = New System.Drawing.Point(117, 227)
        Me.TextBoxSubMatch6.Name = "TextBoxSubMatch6"
        Me.TextBoxSubMatch6.ReadOnly = True
        Me.TextBoxSubMatch6.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxSubMatch6.TabIndex = 36
        '
        'LabelSubMatch6
        '
        Me.LabelSubMatch6.AutoSize = True
        Me.LabelSubMatch6.Location = New System.Drawing.Point(3, 232)
        Me.LabelSubMatch6.Name = "LabelSubMatch6"
        Me.LabelSubMatch6.Size = New System.Drawing.Size(79, 12)
        Me.LabelSubMatch6.TabIndex = 35
        Me.LabelSubMatch6.Text = "サブマッチ6結果"
        '
        'LabelSubMatchOut6
        '
        Me.LabelSubMatchOut6.AutoSize = True
        Me.LabelSubMatchOut6.Location = New System.Drawing.Point(76, 231)
        Me.LabelSubMatchOut6.Name = "LabelSubMatchOut6"
        Me.LabelSubMatchOut6.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubMatchOut6.TabIndex = 34
        Me.LabelSubMatchOut6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSubmatchNumbers
        '
        Me.LabelSubmatchNumbers.AutoSize = True
        Me.LabelSubmatchNumbers.Location = New System.Drawing.Point(3, 357)
        Me.LabelSubmatchNumbers.Name = "LabelSubmatchNumbers"
        Me.LabelSubmatchNumbers.Size = New System.Drawing.Size(0, 12)
        Me.LabelSubmatchNumbers.TabIndex = 49
        Me.LabelSubmatchNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(5, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "サブマッチコピー"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonClrCheckStrings
        '
        Me.ButtonClrCheckStrings.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonClrCheckStrings.Location = New System.Drawing.Point(88, 39)
        Me.ButtonClrCheckStrings.Name = "ButtonClrCheckStrings"
        Me.ButtonClrCheckStrings.Size = New System.Drawing.Size(23, 21)
        Me.ButtonClrCheckStrings.TabIndex = 51
        Me.ButtonClrCheckStrings.Text = "C"
        Me.ButtonClrCheckStrings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 525)
        Me.Controls.Add(Me.ButtonClrCheckStrings)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelSubmatchNumbers)
        Me.Controls.Add(Me.TextBoxSubMatch10)
        Me.Controls.Add(Me.LabelSubMatch10)
        Me.Controls.Add(Me.LabelSubMatchOut10)
        Me.Controls.Add(Me.TextBoxSubMatch9)
        Me.Controls.Add(Me.LabelSubMatch9)
        Me.Controls.Add(Me.LabelSubMatchOut9)
        Me.Controls.Add(Me.TextBoxSubMatch8)
        Me.Controls.Add(Me.LabelSubMatch8)
        Me.Controls.Add(Me.LabelSubMatchOut8)
        Me.Controls.Add(Me.TextBoxSubMatch7)
        Me.Controls.Add(Me.LabelSubMatch7)
        Me.Controls.Add(Me.LabelSubMatchOut7)
        Me.Controls.Add(Me.TextBoxSubMatch6)
        Me.Controls.Add(Me.LabelSubMatch6)
        Me.Controls.Add(Me.LabelSubMatchOut6)
        Me.Controls.Add(Me.TextBoxSubMatch5)
        Me.Controls.Add(Me.LabelSubMatch5)
        Me.Controls.Add(Me.LabelSubMatchOut5)
        Me.Controls.Add(Me.TextBoxSubMatch4)
        Me.Controls.Add(Me.LabelSubMatch4)
        Me.Controls.Add(Me.LabelSubMatchOut4)
        Me.Controls.Add(Me.TextBoxSubMatch3)
        Me.Controls.Add(Me.LabelSubMatch3)
        Me.Controls.Add(Me.LabelSubMatchOut3)
        Me.Controls.Add(Me.TextBoxSubMatch2)
        Me.Controls.Add(Me.LabelSubMatch2)
        Me.Controls.Add(Me.LabelSubMatchOut2)
        Me.Controls.Add(Me.TextBoxSubMatch1)
        Me.Controls.Add(Me.LabelSubMatch1)
        Me.Controls.Add(Me.LabelSubMatchOut1)
        Me.Controls.Add(Me.LabelRegPatLength)
        Me.Controls.Add(Me.LabelCehckStrLength)
        Me.Controls.Add(Me.TextBoxMatchedText)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LinkLabelVBDNRegExp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelCheckResult)
        Me.Controls.Add(Me.LabelMatchOrNot)
        Me.Controls.Add(Me.LabelEffectiveStringsLength)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabelVBSRegExp)
        Me.Controls.Add(Me.LabelCheckStrings)
        Me.Controls.Add(Me.LabelRegPattern)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxCheckStrigs)
        Me.Controls.Add(Me.TextBoxRegPattern)
        Me.Name = "Form1"
        Me.Text = "正規表現テスト"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxRegPattern As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCheckStrigs As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelRegPattern As System.Windows.Forms.Label
    Friend WithEvents LabelCheckStrings As System.Windows.Forms.Label
    Friend WithEvents LinkLabelVBSRegExp As System.Windows.Forms.LinkLabel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelEffectiveStringsLength As System.Windows.Forms.Label
    Friend WithEvents LabelMatchOrNot As System.Windows.Forms.Label
    Friend WithEvents LabelCheckResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabelVBDNRegExp As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxMatchedText As System.Windows.Forms.TextBox
    Friend WithEvents LabelCehckStrLength As System.Windows.Forms.Label
    Friend WithEvents LabelRegPatLength As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch1 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch2 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch3 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch3 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch5 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch5 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch4 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch4 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch10 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch10 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch9 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch9 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch8 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch8 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch7 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch7 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubMatch6 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubMatch6 As System.Windows.Forms.Label
    Friend WithEvents LabelSubMatchOut6 As System.Windows.Forms.Label
    Friend WithEvents LabelSubmatchNumbers As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonClrCheckStrings As System.Windows.Forms.Button

End Class
