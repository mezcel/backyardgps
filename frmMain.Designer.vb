<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGpsUI
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGpsUI))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.spBU353 = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrBaud = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLatitude = New System.Windows.Forms.TextBox()
        Me.txtLongitude = New System.Windows.Forms.TextBox()
        Me.txtLogDisp = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtHirizDilution = New System.Windows.Forms.TextBox()
        Me.lblHorizontalDilution = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblSignalStrength = New System.Windows.Forms.Label()
        Me.btnUpdateComPortNumber = New System.Windows.Forms.Button()
        Me.cbxCOM = New System.Windows.Forms.ComboBox()
        Me.lostSignalHz = New System.Windows.Forms.TextBox()
        Me.lblSatelites = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblZoom = New System.Windows.Forms.Label()
        Me.hsbZoom = New System.Windows.Forms.HScrollBar()
        Me.lblCOMPort = New System.Windows.Forms.Label()
        Me.txtNoSateltites = New System.Windows.Forms.TextBox()
        Me.txtAltitude = New System.Windows.Forms.TextBox()
        Me.lblAltitude = New System.Windows.Forms.Label()
        Me.txtNS = New System.Windows.Forms.TextBox()
        Me.txtEW = New System.Windows.Forms.TextBox()
        Me.btnDecimalDegree = New System.Windows.Forms.Button()
        Me.btnSateliteInfo = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblGPGSA = New System.Windows.Forms.Label()
        Me.lblGPGSV = New System.Windows.Forms.Label()
        Me.lblGPRMC = New System.Windows.Forms.Label()
        Me.lblPDOP = New System.Windows.Forms.Label()
        Me.lblHDOP = New System.Windows.Forms.Label()
        Me.lblVDOP = New System.Windows.Forms.Label()
        Me.lblTotalNoOfSVs = New System.Windows.Forms.Label()
        Me.lblSOG = New System.Windows.Forms.Label()
        Me.lblfixtype = New System.Windows.Forms.Label()
        Me.noofsats = New System.Windows.Forms.Label()
        Me.lblCOG = New System.Windows.Forms.Label()
        Me.txtRMC_Lat = New System.Windows.Forms.TextBox()
        Me.txtRMC_Lon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRMC_SOG = New System.Windows.Forms.TextBox()
        Me.txtRMC_COG = New System.Windows.Forms.TextBox()
        Me.txtRMC_NS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRMC_EW = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRMC_Status = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRMC_UtcTime = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRMC_UtcDate = New System.Windows.Forms.TextBox()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.lblSvPrNo0 = New System.Windows.Forms.Label()
        Me.lblElevation0 = New System.Windows.Forms.Label()
        Me.lblSNR0 = New System.Windows.Forms.Label()
        Me.lblAzimuth0 = New System.Windows.Forms.Label()
        Me.lblSNR1 = New System.Windows.Forms.Label()
        Me.lblAzimuth1 = New System.Windows.Forms.Label()
        Me.lblElevation1 = New System.Windows.Forms.Label()
        Me.lblSvPrNo1 = New System.Windows.Forms.Label()
        Me.lblSNR3 = New System.Windows.Forms.Label()
        Me.lblAzimuth3 = New System.Windows.Forms.Label()
        Me.lblElevation3 = New System.Windows.Forms.Label()
        Me.lblSvPrNo3 = New System.Windows.Forms.Label()
        Me.lblSNR2 = New System.Windows.Forms.Label()
        Me.lblAzimuth2 = New System.Windows.Forms.Label()
        Me.lblElevation2 = New System.Windows.Forms.Label()
        Me.lblSvPrNo2 = New System.Windows.Forms.Label()
        Me.lblNoOfMsgs = New System.Windows.Forms.Label()
        Me.lblMsgNo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(339, 46)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(142, 100)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "START"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'spBU353
        '
        Me.spBU353.BaudRate = 4800
        Me.spBU353.PortName = "COM"
        '
        'tmrBaud
        '
        Me.tmrBaud.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Latitude"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Longitude"
        '
        'txtLatitude
        '
        Me.txtLatitude.BackColor = System.Drawing.Color.White
        Me.txtLatitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitude.Location = New System.Drawing.Point(35, 20)
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.ReadOnly = True
        Me.txtLatitude.Size = New System.Drawing.Size(70, 22)
        Me.txtLatitude.TabIndex = 4
        '
        'txtLongitude
        '
        Me.txtLongitude.BackColor = System.Drawing.Color.White
        Me.txtLongitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitude.Location = New System.Drawing.Point(131, 20)
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.ReadOnly = True
        Me.txtLongitude.Size = New System.Drawing.Size(70, 22)
        Me.txtLongitude.TabIndex = 5
        '
        'txtLogDisp
        '
        Me.txtLogDisp.BackColor = System.Drawing.Color.White
        Me.txtLogDisp.Location = New System.Drawing.Point(12, 46)
        Me.txtLogDisp.Multiline = True
        Me.txtLogDisp.Name = "txtLogDisp"
        Me.txtLogDisp.ReadOnly = True
        Me.txtLogDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogDisp.Size = New System.Drawing.Size(321, 206)
        Me.txtLogDisp.TabIndex = 7
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(340, 152)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(142, 100)
        Me.btnLog.TabIndex = 8
        Me.btnLog.Text = "LOG"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(253, 578)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(59, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(253, 608)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(59, 20)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHirizDilution
        '
        Me.txtHirizDilution.BackColor = System.Drawing.Color.White
        Me.txtHirizDilution.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtHirizDilution.Location = New System.Drawing.Point(318, 272)
        Me.txtHirizDilution.Name = "txtHirizDilution"
        Me.txtHirizDilution.ReadOnly = True
        Me.txtHirizDilution.Size = New System.Drawing.Size(42, 20)
        Me.txtHirizDilution.TabIndex = 14
        Me.txtHirizDilution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHorizontalDilution
        '
        Me.lblHorizontalDilution.AutoSize = True
        Me.lblHorizontalDilution.Location = New System.Drawing.Point(366, 279)
        Me.lblHorizontalDilution.Name = "lblHorizontalDilution"
        Me.lblHorizontalDilution.Size = New System.Drawing.Size(87, 13)
        Me.lblHorizontalDilution.TabIndex = 16
        Me.lblHorizontalDilution.Text = "PDOP (Ideal < 1)"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(233, 608)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 13)
        Me.lblY.TabIndex = 18
        Me.lblY.Text = "Y"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(233, 578)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 17
        Me.lblX.Text = "X"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblSignalStrength
        '
        Me.lblSignalStrength.AutoSize = True
        Me.lblSignalStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignalStrength.Location = New System.Drawing.Point(315, 396)
        Me.lblSignalStrength.Name = "lblSignalStrength"
        Me.lblSignalStrength.Size = New System.Drawing.Size(89, 13)
        Me.lblSignalStrength.TabIndex = 20
        Me.lblSignalStrength.Text = "Signal Quality:"
        Me.lblSignalStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdateComPortNumber
        '
        Me.btnUpdateComPortNumber.BackColor = System.Drawing.Color.LightGray
        Me.btnUpdateComPortNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateComPortNumber.Location = New System.Drawing.Point(339, 0)
        Me.btnUpdateComPortNumber.Name = "btnUpdateComPortNumber"
        Me.btnUpdateComPortNumber.Size = New System.Drawing.Size(79, 43)
        Me.btnUpdateComPortNumber.TabIndex = 21
        Me.btnUpdateComPortNumber.Text = "Refresh COM"
        Me.btnUpdateComPortNumber.UseVisualStyleBackColor = False
        '
        'cbxCOM
        '
        Me.cbxCOM.BackColor = System.Drawing.Color.White
        Me.cbxCOM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCOM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxCOM.FormattingEnabled = True
        Me.cbxCOM.Location = New System.Drawing.Point(424, 21)
        Me.cbxCOM.Name = "cbxCOM"
        Me.cbxCOM.Size = New System.Drawing.Size(57, 21)
        Me.cbxCOM.TabIndex = 22
        '
        'lostSignalHz
        '
        Me.lostSignalHz.Location = New System.Drawing.Point(318, 578)
        Me.lostSignalHz.Multiline = True
        Me.lostSignalHz.Name = "lostSignalHz"
        Me.lostSignalHz.ReadOnly = True
        Me.lostSignalHz.Size = New System.Drawing.Size(164, 50)
        Me.lostSignalHz.TabIndex = 23
        Me.lostSignalHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSatelites
        '
        Me.lblSatelites.AutoSize = True
        Me.lblSatelites.Location = New System.Drawing.Point(366, 306)
        Me.lblSatelites.Name = "lblSatelites"
        Me.lblSatelites.Size = New System.Drawing.Size(99, 13)
        Me.lblSatelites.TabIndex = 24
        Me.lblSatelites.Text = "Number of Satelites"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(318, 412)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 160)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 272)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lblZoom
        '
        Me.lblZoom.AutoSize = True
        Me.lblZoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZoom.Location = New System.Drawing.Point(192, 603)
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(35, 25)
        Me.lblZoom.TabIndex = 26
        Me.lblZoom.Text = "x1"
        '
        'hsbZoom
        '
        Me.hsbZoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsbZoom.LargeChange = 1
        Me.hsbZoom.Location = New System.Drawing.Point(12, 575)
        Me.hsbZoom.Maximum = 4
        Me.hsbZoom.Minimum = -2
        Me.hsbZoom.Name = "hsbZoom"
        Me.hsbZoom.Size = New System.Drawing.Size(177, 53)
        Me.hsbZoom.TabIndex = 27
        Me.hsbZoom.Value = 1
        '
        'lblCOMPort
        '
        Me.lblCOMPort.AutoSize = True
        Me.lblCOMPort.Location = New System.Drawing.Point(421, 5)
        Me.lblCOMPort.Name = "lblCOMPort"
        Me.lblCOMPort.Size = New System.Drawing.Size(63, 13)
        Me.lblCOMPort.TabIndex = 30
        Me.lblCOMPort.Text = "Serial COM:"
        '
        'txtNoSateltites
        '
        Me.txtNoSateltites.BackColor = System.Drawing.Color.White
        Me.txtNoSateltites.Location = New System.Drawing.Point(318, 299)
        Me.txtNoSateltites.Name = "txtNoSateltites"
        Me.txtNoSateltites.ReadOnly = True
        Me.txtNoSateltites.Size = New System.Drawing.Size(42, 20)
        Me.txtNoSateltites.TabIndex = 31
        Me.txtNoSateltites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAltitude
        '
        Me.txtAltitude.BackColor = System.Drawing.Color.White
        Me.txtAltitude.Location = New System.Drawing.Point(319, 326)
        Me.txtAltitude.Name = "txtAltitude"
        Me.txtAltitude.ReadOnly = True
        Me.txtAltitude.Size = New System.Drawing.Size(41, 20)
        Me.txtAltitude.TabIndex = 32
        Me.txtAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.Location = New System.Drawing.Point(366, 333)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(83, 13)
        Me.lblAltitude.TabIndex = 33
        Me.lblAltitude.Text = "Altitude (Meters)"
        '
        'txtNS
        '
        Me.txtNS.BackColor = System.Drawing.Color.White
        Me.txtNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNS.Location = New System.Drawing.Point(12, 20)
        Me.txtNS.Name = "txtNS"
        Me.txtNS.ReadOnly = True
        Me.txtNS.Size = New System.Drawing.Size(20, 22)
        Me.txtNS.TabIndex = 34
        Me.txtNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEW
        '
        Me.txtEW.BackColor = System.Drawing.Color.White
        Me.txtEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEW.Location = New System.Drawing.Point(108, 20)
        Me.txtEW.Name = "txtEW"
        Me.txtEW.ReadOnly = True
        Me.txtEW.Size = New System.Drawing.Size(20, 22)
        Me.txtEW.TabIndex = 35
        Me.txtEW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDecimalDegree
        '
        Me.btnDecimalDegree.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDecimalDegree.Location = New System.Drawing.Point(207, 0)
        Me.btnDecimalDegree.Name = "btnDecimalDegree"
        Me.btnDecimalDegree.Size = New System.Drawing.Size(126, 42)
        Me.btnDecimalDegree.TabIndex = 36
        Me.btnDecimalDegree.Text = "degree coordinate"
        Me.btnDecimalDegree.UseVisualStyleBackColor = False
        '
        'btnSateliteInfo
        '
        Me.btnSateliteInfo.BackColor = System.Drawing.Color.White
        Me.btnSateliteInfo.Location = New System.Drawing.Point(318, 353)
        Me.btnSateliteInfo.Name = "btnSateliteInfo"
        Me.btnSateliteInfo.Size = New System.Drawing.Size(163, 35)
        Me.btnSateliteInfo.TabIndex = 37
        Me.btnSateliteInfo.Text = "Open Satelite Panel"
        Me.btnSateliteInfo.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(804, 637)
        Me.ShapeContainer1.TabIndex = 38
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Black
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 494
        Me.LineShape1.X2 = 494
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 640
        '
        'lblGPGSA
        '
        Me.lblGPGSA.AutoSize = True
        Me.lblGPGSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPGSA.Location = New System.Drawing.Point(499, 5)
        Me.lblGPGSA.Name = "lblGPGSA"
        Me.lblGPGSA.Size = New System.Drawing.Size(49, 13)
        Me.lblGPGSA.TabIndex = 39
        Me.lblGPGSA.Text = "GPGSA"
        '
        'lblGPGSV
        '
        Me.lblGPGSV.AutoSize = True
        Me.lblGPGSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPGSV.Location = New System.Drawing.Point(497, 127)
        Me.lblGPGSV.Name = "lblGPGSV"
        Me.lblGPGSV.Size = New System.Drawing.Size(49, 13)
        Me.lblGPGSV.TabIndex = 40
        Me.lblGPGSV.Text = "GPGSV"
        '
        'lblGPRMC
        '
        Me.lblGPRMC.AutoSize = True
        Me.lblGPRMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPRMC.Location = New System.Drawing.Point(499, 302)
        Me.lblGPRMC.Name = "lblGPRMC"
        Me.lblGPRMC.Size = New System.Drawing.Size(51, 13)
        Me.lblGPRMC.TabIndex = 41
        Me.lblGPRMC.Text = "GPRMC"
        '
        'lblPDOP
        '
        Me.lblPDOP.AutoSize = True
        Me.lblPDOP.Location = New System.Drawing.Point(496, 65)
        Me.lblPDOP.Name = "lblPDOP"
        Me.lblPDOP.Size = New System.Drawing.Size(37, 13)
        Me.lblPDOP.TabIndex = 42
        Me.lblPDOP.Text = "PDOP"
        '
        'lblHDOP
        '
        Me.lblHDOP.AutoSize = True
        Me.lblHDOP.Location = New System.Drawing.Point(496, 78)
        Me.lblHDOP.Name = "lblHDOP"
        Me.lblHDOP.Size = New System.Drawing.Size(38, 13)
        Me.lblHDOP.TabIndex = 43
        Me.lblHDOP.Text = "HDOP"
        '
        'lblVDOP
        '
        Me.lblVDOP.AutoSize = True
        Me.lblVDOP.Location = New System.Drawing.Point(496, 91)
        Me.lblVDOP.Name = "lblVDOP"
        Me.lblVDOP.Size = New System.Drawing.Size(37, 13)
        Me.lblVDOP.TabIndex = 44
        Me.lblVDOP.Text = "VDOP"
        '
        'lblTotalNoOfSVs
        '
        Me.lblTotalNoOfSVs.AutoSize = True
        Me.lblTotalNoOfSVs.Location = New System.Drawing.Point(688, 152)
        Me.lblTotalNoOfSVs.Name = "lblTotalNoOfSVs"
        Me.lblTotalNoOfSVs.Size = New System.Drawing.Size(50, 13)
        Me.lblTotalNoOfSVs.TabIndex = 49
        Me.lblTotalNoOfSVs.Text = "# Of SVs"
        '
        'lblSOG
        '
        Me.lblSOG.AutoSize = True
        Me.lblSOG.Location = New System.Drawing.Point(497, 523)
        Me.lblSOG.Name = "lblSOG"
        Me.lblSOG.Size = New System.Drawing.Size(70, 13)
        Me.lblSOG.TabIndex = 50
        Me.lblSOG.Text = "Speed (SOG)"
        '
        'lblfixtype
        '
        Me.lblfixtype.AutoSize = True
        Me.lblfixtype.Location = New System.Drawing.Point(496, 39)
        Me.lblfixtype.Name = "lblfixtype"
        Me.lblfixtype.Size = New System.Drawing.Size(50, 13)
        Me.lblfixtype.TabIndex = 55
        Me.lblfixtype.Text = "Fix Type:"
        '
        'noofsats
        '
        Me.noofsats.AutoSize = True
        Me.noofsats.Location = New System.Drawing.Point(496, 52)
        Me.noofsats.Name = "noofsats"
        Me.noofsats.Size = New System.Drawing.Size(62, 13)
        Me.noofsats.TabIndex = 56
        Me.noofsats.Text = "No Of Sats."
        '
        'lblCOG
        '
        Me.lblCOG.AutoSize = True
        Me.lblCOG.Location = New System.Drawing.Point(649, 523)
        Me.lblCOG.Name = "lblCOG"
        Me.lblCOG.Size = New System.Drawing.Size(72, 13)
        Me.lblCOG.TabIndex = 57
        Me.lblCOG.Text = "Course (COG)"
        '
        'txtRMC_Lat
        '
        Me.txtRMC_Lat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_Lat.Location = New System.Drawing.Point(502, 431)
        Me.txtRMC_Lat.Name = "txtRMC_Lat"
        Me.txtRMC_Lat.Size = New System.Drawing.Size(144, 35)
        Me.txtRMC_Lat.TabIndex = 61
        '
        'txtRMC_Lon
        '
        Me.txtRMC_Lon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_Lon.Location = New System.Drawing.Point(501, 485)
        Me.txtRMC_Lon.Name = "txtRMC_Lon"
        Me.txtRMC_Lon.Size = New System.Drawing.Size(144, 35)
        Me.txtRMC_Lon.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Latitude"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 469)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Longitude"
        '
        'txtRMC_SOG
        '
        Me.txtRMC_SOG.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_SOG.Location = New System.Drawing.Point(501, 539)
        Me.txtRMC_SOG.Name = "txtRMC_SOG"
        Me.txtRMC_SOG.Size = New System.Drawing.Size(144, 35)
        Me.txtRMC_SOG.TabIndex = 65
        '
        'txtRMC_COG
        '
        Me.txtRMC_COG.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_COG.Location = New System.Drawing.Point(654, 539)
        Me.txtRMC_COG.Name = "txtRMC_COG"
        Me.txtRMC_COG.Size = New System.Drawing.Size(137, 35)
        Me.txtRMC_COG.TabIndex = 66
        '
        'txtRMC_NS
        '
        Me.txtRMC_NS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_NS.Location = New System.Drawing.Point(652, 431)
        Me.txtRMC_NS.Name = "txtRMC_NS"
        Me.txtRMC_NS.Size = New System.Drawing.Size(65, 35)
        Me.txtRMC_NS.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(648, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "NorthSouth"
        '
        'txtRMC_EW
        '
        Me.txtRMC_EW.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_EW.Location = New System.Drawing.Point(654, 485)
        Me.txtRMC_EW.Name = "txtRMC_EW"
        Me.txtRMC_EW.Size = New System.Drawing.Size(65, 35)
        Me.txtRMC_EW.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(650, 469)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "East West"
        '
        'txtRMC_Status
        '
        Me.txtRMC_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_Status.Location = New System.Drawing.Point(501, 593)
        Me.txtRMC_Status.Name = "txtRMC_Status"
        Me.txtRMC_Status.Size = New System.Drawing.Size(65, 38)
        Me.txtRMC_Status.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(498, 577)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Status"
        '
        'txtRMC_UtcTime
        '
        Me.txtRMC_UtcTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_UtcTime.Location = New System.Drawing.Point(500, 341)
        Me.txtRMC_UtcTime.Name = "txtRMC_UtcTime"
        Me.txtRMC_UtcTime.Size = New System.Drawing.Size(291, 35)
        Me.txtRMC_UtcTime.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(497, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "UTC"
        '
        'txtRMC_UtcDate
        '
        Me.txtRMC_UtcDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRMC_UtcDate.Location = New System.Drawing.Point(500, 377)
        Me.txtRMC_UtcDate.Name = "txtRMC_UtcDate"
        Me.txtRMC_UtcDate.Size = New System.Drawing.Size(291, 35)
        Me.txtRMC_UtcDate.TabIndex = 77
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Location = New System.Drawing.Point(497, 26)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(37, 13)
        Me.lblmode.TabIndex = 78
        Me.lblmode.Text = "Mode:"
        '
        'lblSvPrNo0
        '
        Me.lblSvPrNo0.AutoSize = True
        Me.lblSvPrNo0.Location = New System.Drawing.Point(502, 176)
        Me.lblSvPrNo0.Name = "lblSvPrNo0"
        Me.lblSvPrNo0.Size = New System.Drawing.Size(79, 13)
        Me.lblSvPrNo0.TabIndex = 79
        Me.lblSvPrNo0.Text = "SV PR Number"
        '
        'lblElevation0
        '
        Me.lblElevation0.AutoSize = True
        Me.lblElevation0.Location = New System.Drawing.Point(530, 189)
        Me.lblElevation0.Name = "lblElevation0"
        Me.lblElevation0.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation0.TabIndex = 80
        Me.lblElevation0.Text = "Elevation"
        '
        'lblSNR0
        '
        Me.lblSNR0.AutoSize = True
        Me.lblSNR0.Location = New System.Drawing.Point(551, 215)
        Me.lblSNR0.Name = "lblSNR0"
        Me.lblSNR0.Size = New System.Drawing.Size(30, 13)
        Me.lblSNR0.TabIndex = 82
        Me.lblSNR0.Text = "SNR"
        '
        'lblAzimuth0
        '
        Me.lblAzimuth0.AutoSize = True
        Me.lblAzimuth0.Location = New System.Drawing.Point(537, 202)
        Me.lblAzimuth0.Name = "lblAzimuth0"
        Me.lblAzimuth0.Size = New System.Drawing.Size(44, 13)
        Me.lblAzimuth0.TabIndex = 81
        Me.lblAzimuth0.Text = "Azimuth"
        '
        'lblSNR1
        '
        Me.lblSNR1.AutoSize = True
        Me.lblSNR1.Location = New System.Drawing.Point(676, 215)
        Me.lblSNR1.Name = "lblSNR1"
        Me.lblSNR1.Size = New System.Drawing.Size(30, 13)
        Me.lblSNR1.TabIndex = 86
        Me.lblSNR1.Text = "SNR"
        '
        'lblAzimuth1
        '
        Me.lblAzimuth1.AutoSize = True
        Me.lblAzimuth1.Location = New System.Drawing.Point(662, 202)
        Me.lblAzimuth1.Name = "lblAzimuth1"
        Me.lblAzimuth1.Size = New System.Drawing.Size(44, 13)
        Me.lblAzimuth1.TabIndex = 85
        Me.lblAzimuth1.Text = "Azimuth"
        '
        'lblElevation1
        '
        Me.lblElevation1.AutoSize = True
        Me.lblElevation1.Location = New System.Drawing.Point(655, 189)
        Me.lblElevation1.Name = "lblElevation1"
        Me.lblElevation1.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation1.TabIndex = 84
        Me.lblElevation1.Text = "Elevation"
        '
        'lblSvPrNo1
        '
        Me.lblSvPrNo1.AutoSize = True
        Me.lblSvPrNo1.Location = New System.Drawing.Point(627, 176)
        Me.lblSvPrNo1.Name = "lblSvPrNo1"
        Me.lblSvPrNo1.Size = New System.Drawing.Size(79, 13)
        Me.lblSvPrNo1.TabIndex = 83
        Me.lblSvPrNo1.Text = "SV PR Number"
        '
        'lblSNR3
        '
        Me.lblSNR3.AutoSize = True
        Me.lblSNR3.Location = New System.Drawing.Point(676, 278)
        Me.lblSNR3.Name = "lblSNR3"
        Me.lblSNR3.Size = New System.Drawing.Size(30, 13)
        Me.lblSNR3.TabIndex = 94
        Me.lblSNR3.Text = "SNR"
        '
        'lblAzimuth3
        '
        Me.lblAzimuth3.AutoSize = True
        Me.lblAzimuth3.Location = New System.Drawing.Point(662, 265)
        Me.lblAzimuth3.Name = "lblAzimuth3"
        Me.lblAzimuth3.Size = New System.Drawing.Size(44, 13)
        Me.lblAzimuth3.TabIndex = 93
        Me.lblAzimuth3.Text = "Azimuth"
        '
        'lblElevation3
        '
        Me.lblElevation3.AutoSize = True
        Me.lblElevation3.Location = New System.Drawing.Point(655, 252)
        Me.lblElevation3.Name = "lblElevation3"
        Me.lblElevation3.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation3.TabIndex = 92
        Me.lblElevation3.Text = "Elevation"
        '
        'lblSvPrNo3
        '
        Me.lblSvPrNo3.AutoSize = True
        Me.lblSvPrNo3.Location = New System.Drawing.Point(627, 239)
        Me.lblSvPrNo3.Name = "lblSvPrNo3"
        Me.lblSvPrNo3.Size = New System.Drawing.Size(79, 13)
        Me.lblSvPrNo3.TabIndex = 91
        Me.lblSvPrNo3.Text = "SV PR Number"
        '
        'lblSNR2
        '
        Me.lblSNR2.AutoSize = True
        Me.lblSNR2.Location = New System.Drawing.Point(551, 278)
        Me.lblSNR2.Name = "lblSNR2"
        Me.lblSNR2.Size = New System.Drawing.Size(30, 13)
        Me.lblSNR2.TabIndex = 90
        Me.lblSNR2.Text = "SNR"
        '
        'lblAzimuth2
        '
        Me.lblAzimuth2.AutoSize = True
        Me.lblAzimuth2.Location = New System.Drawing.Point(537, 265)
        Me.lblAzimuth2.Name = "lblAzimuth2"
        Me.lblAzimuth2.Size = New System.Drawing.Size(44, 13)
        Me.lblAzimuth2.TabIndex = 89
        Me.lblAzimuth2.Text = "Azimuth"
        '
        'lblElevation2
        '
        Me.lblElevation2.AutoSize = True
        Me.lblElevation2.Location = New System.Drawing.Point(530, 252)
        Me.lblElevation2.Name = "lblElevation2"
        Me.lblElevation2.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation2.TabIndex = 88
        Me.lblElevation2.Text = "Elevation"
        '
        'lblSvPrNo2
        '
        Me.lblSvPrNo2.AutoSize = True
        Me.lblSvPrNo2.Location = New System.Drawing.Point(502, 239)
        Me.lblSvPrNo2.Name = "lblSvPrNo2"
        Me.lblSvPrNo2.Size = New System.Drawing.Size(79, 13)
        Me.lblSvPrNo2.TabIndex = 87
        Me.lblSvPrNo2.Text = "SV PR Number"
        '
        'lblNoOfMsgs
        '
        Me.lblNoOfMsgs.AutoSize = True
        Me.lblNoOfMsgs.Location = New System.Drawing.Point(502, 152)
        Me.lblNoOfMsgs.Name = "lblNoOfMsgs"
        Me.lblNoOfMsgs.Size = New System.Drawing.Size(79, 13)
        Me.lblNoOfMsgs.TabIndex = 95
        Me.lblNoOfMsgs.Text = "# Of Messages"
        '
        'lblMsgNo
        '
        Me.lblMsgNo.AutoSize = True
        Me.lblMsgNo.Location = New System.Drawing.Point(599, 152)
        Me.lblMsgNo.Name = "lblMsgNo"
        Me.lblMsgNo.Size = New System.Drawing.Size(60, 13)
        Me.lblMsgNo.TabIndex = 96
        Me.lblMsgNo.Text = "Message #"
        '
        'frmGpsUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 637)
        Me.Controls.Add(Me.lblMsgNo)
        Me.Controls.Add(Me.lblNoOfMsgs)
        Me.Controls.Add(Me.lblSNR3)
        Me.Controls.Add(Me.lblAzimuth3)
        Me.Controls.Add(Me.lblElevation3)
        Me.Controls.Add(Me.lblSvPrNo3)
        Me.Controls.Add(Me.lblSNR2)
        Me.Controls.Add(Me.lblAzimuth2)
        Me.Controls.Add(Me.lblElevation2)
        Me.Controls.Add(Me.lblSvPrNo2)
        Me.Controls.Add(Me.lblSNR1)
        Me.Controls.Add(Me.lblAzimuth1)
        Me.Controls.Add(Me.lblElevation1)
        Me.Controls.Add(Me.lblSvPrNo1)
        Me.Controls.Add(Me.lblSNR0)
        Me.Controls.Add(Me.lblAzimuth0)
        Me.Controls.Add(Me.lblElevation0)
        Me.Controls.Add(Me.lblSvPrNo0)
        Me.Controls.Add(Me.lblmode)
        Me.Controls.Add(Me.txtRMC_UtcDate)
        Me.Controls.Add(Me.txtRMC_UtcTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRMC_Status)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRMC_EW)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRMC_NS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRMC_COG)
        Me.Controls.Add(Me.txtRMC_SOG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRMC_Lon)
        Me.Controls.Add(Me.txtRMC_Lat)
        Me.Controls.Add(Me.lblCOG)
        Me.Controls.Add(Me.noofsats)
        Me.Controls.Add(Me.lblfixtype)
        Me.Controls.Add(Me.lblSOG)
        Me.Controls.Add(Me.lblTotalNoOfSVs)
        Me.Controls.Add(Me.lblVDOP)
        Me.Controls.Add(Me.lblHDOP)
        Me.Controls.Add(Me.lblPDOP)
        Me.Controls.Add(Me.lblGPRMC)
        Me.Controls.Add(Me.lblGPGSV)
        Me.Controls.Add(Me.lblGPGSA)
        Me.Controls.Add(Me.btnSateliteInfo)
        Me.Controls.Add(Me.btnDecimalDegree)
        Me.Controls.Add(Me.txtEW)
        Me.Controls.Add(Me.txtNS)
        Me.Controls.Add(Me.lblAltitude)
        Me.Controls.Add(Me.txtAltitude)
        Me.Controls.Add(Me.txtNoSateltites)
        Me.Controls.Add(Me.lblCOMPort)
        Me.Controls.Add(Me.hsbZoom)
        Me.Controls.Add(Me.lblZoom)
        Me.Controls.Add(Me.lblSatelites)
        Me.Controls.Add(Me.lostSignalHz)
        Me.Controls.Add(Me.cbxCOM)
        Me.Controls.Add(Me.btnUpdateComPortNumber)
        Me.Controls.Add(Me.lblSignalStrength)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblHorizontalDilution)
        Me.Controls.Add(Me.txtHirizDilution)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.txtLogDisp)
        Me.Controls.Add(Me.txtLongitude)
        Me.Controls.Add(Me.txtLatitude)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(820, 676)
        Me.MinimumSize = New System.Drawing.Size(510, 676)
        Me.Name = "frmGpsUI"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackYard GPS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents spBU353 As System.IO.Ports.SerialPort
    Friend WithEvents tmrBaud As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLatitude As System.Windows.Forms.TextBox
    Friend WithEvents txtLongitude As System.Windows.Forms.TextBox
    Friend WithEvents txtLogDisp As System.Windows.Forms.TextBox
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtHirizDilution As System.Windows.Forms.TextBox
    Friend WithEvents lblHorizontalDilution As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblSignalStrength As System.Windows.Forms.Label
    Friend WithEvents btnUpdateComPortNumber As System.Windows.Forms.Button
    Friend WithEvents cbxCOM As System.Windows.Forms.ComboBox
    Friend WithEvents lostSignalHz As System.Windows.Forms.TextBox
    Friend WithEvents lblSatelites As System.Windows.Forms.Label
    Friend WithEvents lblZoom As System.Windows.Forms.Label
    Friend WithEvents hsbZoom As System.Windows.Forms.HScrollBar
    Friend WithEvents lblCOMPort As System.Windows.Forms.Label
    Friend WithEvents txtNoSateltites As System.Windows.Forms.TextBox
    Friend WithEvents txtAltitude As System.Windows.Forms.TextBox
    Friend WithEvents lblAltitude As System.Windows.Forms.Label
    Friend WithEvents txtNS As System.Windows.Forms.TextBox
    Friend WithEvents txtEW As System.Windows.Forms.TextBox
    Friend WithEvents btnDecimalDegree As System.Windows.Forms.Button
    Friend WithEvents btnSateliteInfo As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblGPGSA As System.Windows.Forms.Label
    Friend WithEvents lblGPGSV As System.Windows.Forms.Label
    Friend WithEvents lblGPRMC As System.Windows.Forms.Label
    Friend WithEvents lblPDOP As System.Windows.Forms.Label
    Friend WithEvents lblHDOP As System.Windows.Forms.Label
    Friend WithEvents lblVDOP As System.Windows.Forms.Label
    Friend WithEvents lblTotalNoOfSVs As System.Windows.Forms.Label
    Friend WithEvents lblSOG As System.Windows.Forms.Label
    Friend WithEvents lblfixtype As System.Windows.Forms.Label
    Friend WithEvents noofsats As System.Windows.Forms.Label
    Friend WithEvents lblCOG As System.Windows.Forms.Label
    Friend WithEvents txtRMC_Lat As System.Windows.Forms.TextBox
    Friend WithEvents txtRMC_Lon As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRMC_SOG As System.Windows.Forms.TextBox
    Friend WithEvents txtRMC_COG As System.Windows.Forms.TextBox
    Friend WithEvents txtRMC_NS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRMC_EW As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRMC_Status As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRMC_UtcTime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRMC_UtcDate As System.Windows.Forms.TextBox
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents lblSvPrNo0 As System.Windows.Forms.Label
    Friend WithEvents lblElevation0 As System.Windows.Forms.Label
    Friend WithEvents lblSNR0 As System.Windows.Forms.Label
    Friend WithEvents lblAzimuth0 As System.Windows.Forms.Label
    Friend WithEvents lblSNR1 As System.Windows.Forms.Label
    Friend WithEvents lblAzimuth1 As System.Windows.Forms.Label
    Friend WithEvents lblElevation1 As System.Windows.Forms.Label
    Friend WithEvents lblSvPrNo1 As System.Windows.Forms.Label
    Friend WithEvents lblSNR3 As System.Windows.Forms.Label
    Friend WithEvents lblAzimuth3 As System.Windows.Forms.Label
    Friend WithEvents lblElevation3 As System.Windows.Forms.Label
    Friend WithEvents lblSvPrNo3 As System.Windows.Forms.Label
    Friend WithEvents lblSNR2 As System.Windows.Forms.Label
    Friend WithEvents lblAzimuth2 As System.Windows.Forms.Label
    Friend WithEvents lblElevation2 As System.Windows.Forms.Label
    Friend WithEvents lblSvPrNo2 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfMsgs As System.Windows.Forms.Label
    Friend WithEvents lblMsgNo As System.Windows.Forms.Label

End Class
