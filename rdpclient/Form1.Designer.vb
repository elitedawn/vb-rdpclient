<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rdpclient = New AxMSTSCLib.AxMsRdpClient9()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.constat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ipadd = New System.Windows.Forms.ToolStripStatusLabel()
        Me.uname = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.rdpclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdpclient
        '
        Me.rdpclient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdpclient.Enabled = True
        Me.rdpclient.Location = New System.Drawing.Point(-2, -3)
        Me.rdpclient.Name = "rdpclient"
        Me.rdpclient.OcxState = CType(resources.GetObject("rdpclient.OcxState"), System.Windows.Forms.AxHost.State)
        Me.rdpclient.Size = New System.Drawing.Size(1128, 739)
        Me.rdpclient.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.constat, Me.ipadd, Me.uname})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 735)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1124, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'constat
        '
        Me.constat.Name = "constat"
        Me.constat.Size = New System.Drawing.Size(117, 17)
        Me.constat.Text = "Status: Disconnected"
        '
        'ipadd
        '
        Me.ipadd.Name = "ipadd"
        Me.ipadd.Size = New System.Drawing.Size(65, 17)
        Me.ipadd.Text = "IP Address:"
        '
        'uname
        '
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(71, 17)
        Me.uname.Text = "User Name: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 757)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.rdpclient)
        Me.Name = "Form1"
        Me.Text = "Remote.ly"
        CType(Me.rdpclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdpclient As AxMSTSCLib.AxMsRdpClient9
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents constat As ToolStripStatusLabel
    Friend WithEvents ipadd As ToolStripStatusLabel
    Friend WithEvents uname As ToolStripStatusLabel
End Class
