<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SGroupbox1 = New ZiScan_Uploader.sGroupbox()
        Me.btnUpdate = New ZiScan_Uploader.sButton()
        Me.Alert = New ZiScan_Uploader.sNotification()
        Me.lblResults = New ZiScan_Uploader.sLabel()
        Me.tbLink = New ZiScan_Uploader.sTextbox()
        Me.tbImage = New ZiScan_Uploader.sTextbox()
        Me.SButton1 = New ZiScan_Uploader.sButton()
        Me.SLabel2 = New ZiScan_Uploader.sLabel()
        Me.SLabel1 = New ZiScan_Uploader.sLabel()
        Me.SGroupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SGroupbox1
        '
        Me.SGroupbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.SGroupbox1.Border = True
        Me.SGroupbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SGroupbox1.ContainerColor = System.Drawing.Color.White
        Me.SGroupbox1.Controls.Add(Me.btnUpdate)
        Me.SGroupbox1.Controls.Add(Me.Alert)
        Me.SGroupbox1.Controls.Add(Me.lblResults)
        Me.SGroupbox1.Controls.Add(Me.tbLink)
        Me.SGroupbox1.Controls.Add(Me.tbImage)
        Me.SGroupbox1.Controls.Add(Me.SButton1)
        Me.SGroupbox1.Controls.Add(Me.SLabel2)
        Me.SGroupbox1.Controls.Add(Me.SLabel1)
        Me.SGroupbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGroupbox1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SGroupbox1.HeaderForeColor = System.Drawing.Color.White
        Me.SGroupbox1.HeaderHeight = 40
        Me.SGroupbox1.HeaderShadow = True
        Me.SGroupbox1.HeaderSplitterColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SGroupbox1.HeaderSplitterShadowColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.SGroupbox1.HeaderTitle = "Ziscan Uploader"
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.SGroupbox1.HeaderTitleAlgin = StringFormat1
        Me.SGroupbox1.HeaderTitleFont = New System.Drawing.Font("Arial", 12.0!)
        Me.SGroupbox1.Icon = Global.ZiScan_Uploader.My.Resources.Resources.logo
        Me.SGroupbox1.IconSize = 24
        Me.SGroupbox1.IconVisible = True
        Me.SGroupbox1.Location = New System.Drawing.Point(0, 0)
        Me.SGroupbox1.Name = "SGroupbox1"
        Me.SGroupbox1.Quality = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.SGroupbox1.RoundedCorners = 12
        Me.SGroupbox1.Size = New System.Drawing.Size(345, 193)
        Me.SGroupbox1.SplitterBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SGroupbox1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.SGroupbox1.SplitterHeight = 50
        Me.SGroupbox1.SplitterShadowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SGroupbox1.SplitterVisible = True
        Me.SGroupbox1.TabIndex = 0
        Me.SGroupbox1.Text = "Ziscan Uploader"
        Me.SGroupbox1.TitleSpacing = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUpdate.cBorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnUpdate.cDivider = False
        Me.btnUpdate.cDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.cFillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnUpdate.cFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.cForeColor = System.Drawing.Color.White
        Me.btnUpdate.Checked = False
        Me.btnUpdate.CheckedVisiable = False
        Me.btnUpdate.cImage = Nothing
        Me.btnUpdate.cImageV = False
        Me.btnUpdate.cShadow = True
        Me.btnUpdate.cShadowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnUpdate.cText = "Update"
        Me.btnUpdate.cToggleBackColor = System.Drawing.Color.White
        Me.btnUpdate.cToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUpdate.cToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnUpdate.FontFit = False
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.hBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnUpdate.hDivider = False
        Me.btnUpdate.hDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.hFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.hFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.hForeColor = System.Drawing.Color.White
        Me.btnUpdate.hImage = Nothing
        Me.btnUpdate.hImageV = False
        Me.btnUpdate.hText = "Update"
        Me.btnUpdate.hToggleBackColor = System.Drawing.Color.White
        Me.btnUpdate.hToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUpdate.hToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUpdate.ImageSize = 24
        Me.btnUpdate.ImageSpacing = 5
        Me.btnUpdate.Location = New System.Drawing.Point(176, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.nBorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnUpdate.nDivider = False
        Me.btnUpdate.nDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.nFillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUpdate.nFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.nForeColor = System.Drawing.Color.White
        Me.btnUpdate.nImage = Nothing
        Me.btnUpdate.nImageV = False
        Me.btnUpdate.nText = "Update"
        Me.btnUpdate.nToggleBackColor = System.Drawing.Color.White
        Me.btnUpdate.nToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUpdate.nToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUpdate.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.btnUpdate.RoundedCorners = 8
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "SButton2"
        Me.btnUpdate.TextAlignment = System.Drawing.StringAlignment.Center
        Me.btnUpdate.Visible = False
        '
        'Alert
        '
        Me.Alert.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Alert.coffeeBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Alert.coffeeClose = False
        Me.Alert.coffeeCloseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Alert.coffeeCloseHoverColor = System.Drawing.Color.White
        Me.Alert.coffeeDividerColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Alert.coffeeDividerVisible = False
        Me.Alert.coffeeFillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Alert.coffeeHeader = "Coffee!"
        Me.Alert.coffeeHeaderColor = System.Drawing.Color.White
        Me.Alert.coffeeHeaderFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alert.coffeeIcon = Nothing
        Me.Alert.coffeeIconSize = 36
        Me.Alert.coffeeIconSpacing = 5
        Me.Alert.coffeeIconVisible = False
        Me.Alert.coffeeShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Alert.coffeeText = "This is a custom Notecation!"
        Me.Alert.coffeeTextColor = System.Drawing.Color.White
        Me.Alert.coffeeTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.customBorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Alert.customClose = False
        Me.Alert.customCloseColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Alert.customCloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Alert.customDividerColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Alert.customDividerVisible = False
        Me.Alert.customFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Alert.customHeader = "Uploading!  "
        Me.Alert.customHeaderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Alert.customHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.customIcon = Nothing
        Me.Alert.customIconSize = 36
        Me.Alert.customIconSpacing = 5
        Me.Alert.customIconVisible = False
        Me.Alert.customShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Alert.customText = " Please wait...."
        Me.Alert.customTextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Alert.customTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.errorBorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Alert.errorClose = False
        Me.Alert.errorCloseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Alert.errorCloseHoverColor = System.Drawing.Color.White
        Me.Alert.errorDividerColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Alert.errorDividerVisible = False
        Me.Alert.errorFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Alert.errorHeader = "Error!"
        Me.Alert.errorHeaderColor = System.Drawing.Color.White
        Me.Alert.errorHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.errorIcon = Nothing
        Me.Alert.errorIconSize = 36
        Me.Alert.errorIconSpacing = 5
        Me.Alert.errorIconVisible = False
        Me.Alert.errorShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Alert.errorText = " Could not scan file!"
        Me.Alert.errorTextColor = System.Drawing.Color.White
        Me.Alert.errorTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.infoBorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Alert.infoClose = False
        Me.Alert.infoCloseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Alert.infoCloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Alert.infoDividerColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Alert.infoDividerVisible = False
        Me.Alert.infoFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Alert.infoHeader = "Uploading!"
        Me.Alert.infoHeaderColor = System.Drawing.Color.White
        Me.Alert.infoHeaderFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alert.infoIcon = Nothing
        Me.Alert.infoIconSize = 36
        Me.Alert.infoIconSpacing = 5
        Me.Alert.infoIconVisible = False
        Me.Alert.infoShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Alert.infoText = " Please wait while your file is being scanned."
        Me.Alert.infoTextColor = System.Drawing.Color.White
        Me.Alert.infoTextFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alert.Location = New System.Drawing.Point(12, 152)
        Me.Alert.Name = "Alert"
        Me.Alert.Quality = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.Alert.RoundedCorners = 8
        Me.Alert.Size = New System.Drawing.Size(321, 32)
        Me.Alert.successBorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Alert.successClose = False
        Me.Alert.successCloseColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Alert.successCloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Alert.successDividerColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Alert.successDividerVisible = False
        Me.Alert.successFillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Alert.successHeader = "Success!"
        Me.Alert.successHeaderColor = System.Drawing.Color.White
        Me.Alert.successHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.successIcon = Nothing
        Me.Alert.successIconSize = 36
        Me.Alert.successIconSpacing = 5
        Me.Alert.successIconVisible = False
        Me.Alert.successShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Alert.successText = " Scanned and Uploaded."
        Me.Alert.successTextColor = System.Drawing.Color.White
        Me.Alert.successTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.TabIndex = 8
        Me.Alert.Text = "SNotification1"
        Me.Alert.Type = ZiScan_Uploader.sNotification.Types.Info
        Me.Alert.warningBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Alert.warningClose = False
        Me.Alert.warningCloseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Alert.warningCloseHoverColor = System.Drawing.Color.White
        Me.Alert.warningDividerColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Alert.warningDividerVisible = False
        Me.Alert.warningFillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Alert.warningHeader = "Update!"
        Me.Alert.warningHeaderColor = System.Drawing.Color.White
        Me.Alert.warningHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.warningIcon = Nothing
        Me.Alert.warningIconSize = 36
        Me.Alert.warningIconSpacing = 5
        Me.Alert.warningIconVisible = False
        Me.Alert.warningShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Alert.warningText = " There is a new version."
        Me.Alert.warningTextColor = System.Drawing.Color.White
        Me.Alert.warningTextFont = New System.Drawing.Font("Arial", 12.0!)
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.White
        Me.lblResults.Bubble = True
        Me.lblResults.BubbleColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblResults.FontFit = False
        Me.lblResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblResults.Location = New System.Drawing.Point(279, 79)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.lblResults.RoundedCorners = 8
        Me.lblResults.Size = New System.Drawing.Size(52, 18)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "0/.."
        Me.lblResults.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblResults.TextWrap = True
        '
        'tbLink
        '
        Me.tbLink._Error = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.tbLink.Accept = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tbLink.AcceptBack = System.Drawing.Color.White
        Me.tbLink.AcceptFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.AcceptTrigger = ZiScan_Uploader.sTextbox.TriggerType.Disable
        Me.tbLink.AcceptTriggerDetail = "Example"
        Me.tbLink.BackColor = System.Drawing.Color.Transparent
        Me.tbLink.CustomBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.tbLink.CustomColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.tbLink.CustomFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.CustomTrigger = ZiScan_Uploader.sTextbox.TriggerType.UnderInt
        Me.tbLink.CustomTriggerDetail = "1000"
        Me.tbLink.ErrorBack = System.Drawing.Color.White
        Me.tbLink.ErrorFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.ErrorTrigger = ZiScan_Uploader.sTextbox.TriggerType.Disable
        Me.tbLink.ErrorTriggerDetail = "0"
        Me.tbLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLink.lButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.tbLink.lButtonText = "Copy"
        Me.tbLink.lButtonTextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.LeftButton = True
        Me.tbLink.LeftButtonClickable = False
        Me.tbLink.LeftButtonFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tbLink.LeftButtonImage = Nothing
        Me.tbLink.LeftButtonImageToggled = False
        Me.tbLink.LeftButtonSize = 24
        Me.tbLink.LeftButtonText = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.LeftDivider = True
        Me.tbLink.lHoverButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbLink.Location = New System.Drawing.Point(12, 103)
        Me.tbLink.MaxLength = 32767
        Me.tbLink.Multiline = False
        Me.tbLink.Name = "tbLink"
        Me.tbLink.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tbLink.rButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.tbLink.rButtonText = "Open"
        Me.tbLink.rButtonTextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.ReadOnly = True
        Me.tbLink.Regular = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.tbLink.Regularback = System.Drawing.Color.White
        Me.tbLink.rHoverButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbLink.RightButton = True
        Me.tbLink.RightButtonClickable = False
        Me.tbLink.RightButtonFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tbLink.RightButtonImage = Nothing
        Me.tbLink.RightButtonImageToggled = False
        Me.tbLink.RightButtonSize = 24
        Me.tbLink.RightButtonText = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.RightDivider = True
        Me.tbLink.RoundCorners = 8
        Me.tbLink.ShadowBorder = True
        Me.tbLink.ShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.tbLink.Size = New System.Drawing.Size(321, 29)
        Me.tbLink.TabIndex = 6
        Me.tbLink.Text = "Uploading..."
        Me.tbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbLink.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.tbLink.TextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.Type = ZiScan_Uploader.sTextbox._Type.Custom
        Me.tbLink.UseSystemPasswordChar = False
        Me.tbLink.Warning = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tbLink.WarningBack = System.Drawing.Color.White
        Me.tbLink.WarningFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbLink.WarningTrigger = ZiScan_Uploader.sTextbox.TriggerType.Disable
        Me.tbLink.WarningTriggerDetail = "0"
        '
        'tbImage
        '
        Me.tbImage._Error = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.tbImage.Accept = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tbImage.AcceptBack = System.Drawing.Color.White
        Me.tbImage.AcceptFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.AcceptTrigger = ZiScan_Uploader.sTextbox.TriggerType.Disable
        Me.tbImage.AcceptTriggerDetail = "Example"
        Me.tbImage.BackColor = System.Drawing.Color.Transparent
        Me.tbImage.CustomBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tbImage.CustomColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tbImage.CustomFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.CustomTrigger = ZiScan_Uploader.sTextbox.TriggerType.UnderInt
        Me.tbImage.CustomTriggerDetail = "1000"
        Me.tbImage.ErrorBack = System.Drawing.Color.White
        Me.tbImage.ErrorFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.ErrorTrigger = ZiScan_Uploader.sTextbox.TriggerType.Disable
        Me.tbImage.ErrorTriggerDetail = "0"
        Me.tbImage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbImage.lButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tbImage.lButtonText = "Copy"
        Me.tbImage.lButtonTextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.LeftButton = True
        Me.tbImage.LeftButtonClickable = False
        Me.tbImage.LeftButtonFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tbImage.LeftButtonImage = Nothing
        Me.tbImage.LeftButtonImageToggled = False
        Me.tbImage.LeftButtonSize = 24
        Me.tbImage.LeftButtonText = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.LeftDivider = True
        Me.tbImage.lHoverButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbImage.Location = New System.Drawing.Point(140, 47)
        Me.tbImage.MaxLength = 32767
        Me.tbImage.Multiline = False
        Me.tbImage.Name = "tbImage"
        Me.tbImage.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tbImage.rButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tbImage.rButtonText = "Open"
        Me.tbImage.rButtonTextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.ReadOnly = True
        Me.tbImage.Regular = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.tbImage.Regularback = System.Drawing.Color.White
        Me.tbImage.rHoverButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbImage.RightButton = True
        Me.tbImage.RightButtonClickable = False
        Me.tbImage.RightButtonFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tbImage.RightButtonImage = Nothing
        Me.tbImage.RightButtonImageToggled = False
        Me.tbImage.RightButtonSize = 24
        Me.tbImage.RightButtonText = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.RightDivider = True
        Me.tbImage.RoundCorners = 8
        Me.tbImage.ShadowBorder = True
        Me.tbImage.ShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.tbImage.Size = New System.Drawing.Size(191, 26)
        Me.tbImage.TabIndex = 5
        Me.tbImage.Text = "Uploading..."
        Me.tbImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbImage.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tbImage.TextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.Type = ZiScan_Uploader.sTextbox._Type.Custom
        Me.tbImage.UseSystemPasswordChar = False
        Me.tbImage.Warning = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tbImage.WarningBack = System.Drawing.Color.White
        Me.tbImage.WarningFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tbImage.WarningTrigger = ZiScan_Uploader.sTextbox.TriggerType.Disable
        Me.tbImage.WarningTriggerDetail = "0"
        '
        'SButton1
        '
        Me.SButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SButton1.cBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.cDivider = False
        Me.SButton1.cDividerColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.cFillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.cFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SButton1.cForeColor = System.Drawing.Color.White
        Me.SButton1.Checked = False
        Me.SButton1.CheckedVisiable = False
        Me.SButton1.cImage = Global.ZiScan_Uploader.My.Resources.Resources.copy_128
        Me.SButton1.cImageV = False
        Me.SButton1.cShadow = False
        Me.SButton1.cShadowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SButton1.cText = "Cancel"
        Me.SButton1.cToggleBackColor = System.Drawing.Color.White
        Me.SButton1.cToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.cToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.SButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SButton1.FontFit = False
        Me.SButton1.ForeColor = System.Drawing.Color.White
        Me.SButton1.hBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.SButton1.hDivider = False
        Me.SButton1.hDividerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.SButton1.hFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.SButton1.hFont = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SButton1.hForeColor = System.Drawing.Color.White
        Me.SButton1.hImage = Nothing
        Me.SButton1.hImageV = False
        Me.SButton1.hText = "Cancel"
        Me.SButton1.hToggleBackColor = System.Drawing.Color.White
        Me.SButton1.hToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.hToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.SButton1.ImageSize = 24
        Me.SButton1.ImageSpacing = 5
        Me.SButton1.Location = New System.Drawing.Point(257, 10)
        Me.SButton1.Name = "SButton1"
        Me.SButton1.nBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.nDivider = False
        Me.SButton1.nDividerColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.nFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.nFont = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SButton1.nForeColor = System.Drawing.Color.White
        Me.SButton1.nImage = Nothing
        Me.SButton1.nImageV = True
        Me.SButton1.nText = "Cancel"
        Me.SButton1.nToggleBackColor = System.Drawing.Color.White
        Me.SButton1.nToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.SButton1.nToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.SButton1.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.SButton1.RoundedCorners = 8
        Me.SButton1.Size = New System.Drawing.Size(81, 23)
        Me.SButton1.TabIndex = 4
        Me.SButton1.Text = "SButton1"
        Me.SButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'SLabel2
        '
        Me.SLabel2.BackColor = System.Drawing.Color.White
        Me.SLabel2.Bubble = True
        Me.SLabel2.BubbleColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SLabel2.FontFit = False
        Me.SLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SLabel2.Location = New System.Drawing.Point(12, 79)
        Me.SLabel2.Name = "SLabel2"
        Me.SLabel2.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.SLabel2.RoundedCorners = 8
        Me.SLabel2.Size = New System.Drawing.Size(122, 18)
        Me.SLabel2.TabIndex = 3
        Me.SLabel2.Text = "Result Options"
        Me.SLabel2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.SLabel2.TextWrap = True
        '
        'SLabel1
        '
        Me.SLabel1.BackColor = System.Drawing.Color.White
        Me.SLabel1.Bubble = True
        Me.SLabel1.BubbleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.SLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel1.FontFit = False
        Me.SLabel1.ForeColor = System.Drawing.Color.DarkOrange
        Me.SLabel1.Location = New System.Drawing.Point(10, 50)
        Me.SLabel1.Name = "SLabel1"
        Me.SLabel1.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.SLabel1.RoundedCorners = 8
        Me.SLabel1.Size = New System.Drawing.Size(124, 21)
        Me.SLabel1.TabIndex = 2
        Me.SLabel1.Text = "Image Options"
        Me.SLabel1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.SLabel1.TextWrap = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 193)
        Me.Controls.Add(Me.SGroupbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Uploader"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.SGroupbox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SGroupbox1 As sGroupbox
    Friend WithEvents SButton1 As sButton
    Friend WithEvents SLabel2 As sLabel
    Friend WithEvents SLabel1 As sLabel
    Friend WithEvents Alert As sNotification
    Friend WithEvents lblResults As sLabel
    Friend WithEvents tbLink As sTextbox
    Friend WithEvents tbImage As sTextbox
    Friend WithEvents btnUpdate As sButton
End Class
