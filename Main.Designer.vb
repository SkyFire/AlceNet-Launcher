<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.img_cerrar_off = New System.Windows.Forms.PictureBox()
        Me.img_cerrar_on = New System.Windows.Forms.PictureBox()
        Me.img_minimizar_on = New System.Windows.Forms.PictureBox()
        Me.img_minimizar_off = New System.Windows.Forms.PictureBox()
        Me.img_jugar_on = New System.Windows.Forms.PictureBox()
        Me.img_jugar_off = New System.Windows.Forms.PictureBox()
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AaaaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lba_TituloVentana = New System.Windows.Forms.Label()
        CType(Me.img_cerrar_off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_cerrar_on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_minimizar_on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_minimizar_off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jugar_on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_jugar_off, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'img_cerrar_off
        '
        Me.img_cerrar_off.Image = CType(resources.GetObject("img_cerrar_off.Image"), System.Drawing.Image)
        Me.img_cerrar_off.Location = New System.Drawing.Point(779, 7)
        Me.img_cerrar_off.Name = "img_cerrar_off"
        Me.img_cerrar_off.Size = New System.Drawing.Size(16, 16)
        Me.img_cerrar_off.TabIndex = 0
        Me.img_cerrar_off.TabStop = False
        '
        'img_cerrar_on
        '
        Me.img_cerrar_on.Image = CType(resources.GetObject("img_cerrar_on.Image"), System.Drawing.Image)
        Me.img_cerrar_on.Location = New System.Drawing.Point(779, 7)
        Me.img_cerrar_on.Name = "img_cerrar_on"
        Me.img_cerrar_on.Size = New System.Drawing.Size(16, 16)
        Me.img_cerrar_on.TabIndex = 1
        Me.img_cerrar_on.TabStop = False
        Me.img_cerrar_on.Visible = False
        '
        'img_minimizar_on
        '
        Me.img_minimizar_on.Image = CType(resources.GetObject("img_minimizar_on.Image"), System.Drawing.Image)
        Me.img_minimizar_on.Location = New System.Drawing.Point(756, 6)
        Me.img_minimizar_on.Name = "img_minimizar_on"
        Me.img_minimizar_on.Size = New System.Drawing.Size(16, 16)
        Me.img_minimizar_on.TabIndex = 2
        Me.img_minimizar_on.TabStop = False
        Me.img_minimizar_on.Visible = False
        '
        'img_minimizar_off
        '
        Me.img_minimizar_off.Image = CType(resources.GetObject("img_minimizar_off.Image"), System.Drawing.Image)
        Me.img_minimizar_off.Location = New System.Drawing.Point(756, 6)
        Me.img_minimizar_off.Name = "img_minimizar_off"
        Me.img_minimizar_off.Size = New System.Drawing.Size(16, 16)
        Me.img_minimizar_off.TabIndex = 3
        Me.img_minimizar_off.TabStop = False
        '
        'img_jugar_on
        '
        Me.img_jugar_on.Image = CType(resources.GetObject("img_jugar_on.Image"), System.Drawing.Image)
        Me.img_jugar_on.Location = New System.Drawing.Point(646, 552)
        Me.img_jugar_on.Name = "img_jugar_on"
        Me.img_jugar_on.Size = New System.Drawing.Size(140, 83)
        Me.img_jugar_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_jugar_on.TabIndex = 4
        Me.img_jugar_on.TabStop = False
        Me.img_jugar_on.Visible = False
        '
        'img_jugar_off
        '
        Me.img_jugar_off.Image = CType(resources.GetObject("img_jugar_off.Image"), System.Drawing.Image)
        Me.img_jugar_off.Location = New System.Drawing.Point(646, 552)
        Me.img_jugar_off.Name = "img_jugar_off"
        Me.img_jugar_off.Size = New System.Drawing.Size(140, 83)
        Me.img_jugar_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_jugar_off.TabIndex = 5
        Me.img_jugar_off.TabStop = False
        '
        'nfi
        '
        Me.nfi.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.nfi.BalloonTipText = "ss"
        Me.nfi.BalloonTipTitle = "ccc"
        Me.nfi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "NotifyIcon1"
        Me.nfi.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AaaaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(85, 26)
        '
        'AaaaToolStripMenuItem
        '
        Me.AaaaToolStripMenuItem.Name = "AaaaToolStripMenuItem"
        Me.AaaaToolStripMenuItem.Size = New System.Drawing.Size(84, 22)
        Me.AaaaToolStripMenuItem.Text = "aaaa"
        '
        'Timer1
        '
        '
        'lba_TituloVentana
        '
        Me.lba_TituloVentana.AutoSize = True
        Me.lba_TituloVentana.BackColor = System.Drawing.Color.Transparent
        Me.lba_TituloVentana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lba_TituloVentana.ForeColor = System.Drawing.Color.White
        Me.lba_TituloVentana.Location = New System.Drawing.Point(253, 7)
        Me.lba_TituloVentana.Name = "lba_TituloVentana"
        Me.lba_TituloVentana.Size = New System.Drawing.Size(117, 15)
        Me.lba_TituloVentana.TabIndex = 6
        Me.lba_TituloVentana.Text = "World of Warcraft"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(802, 653)
        Me.Controls.Add(Me.lba_TituloVentana)
        Me.Controls.Add(Me.img_jugar_off)
        Me.Controls.Add(Me.img_jugar_on)
        Me.Controls.Add(Me.img_minimizar_off)
        Me.Controls.Add(Me.img_minimizar_on)
        Me.Controls.Add(Me.img_cerrar_on)
        Me.Controls.Add(Me.img_cerrar_off)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.img_cerrar_off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_cerrar_on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_minimizar_on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_minimizar_off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jugar_on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_jugar_off, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_cerrar_off As System.Windows.Forms.PictureBox
    Friend WithEvents img_cerrar_on As System.Windows.Forms.PictureBox
    Friend WithEvents img_minimizar_on As System.Windows.Forms.PictureBox
    Friend WithEvents img_minimizar_off As System.Windows.Forms.PictureBox
    Friend WithEvents img_jugar_on As System.Windows.Forms.PictureBox
    Friend WithEvents img_jugar_off As System.Windows.Forms.PictureBox
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AaaaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lba_TituloVentana As System.Windows.Forms.Label

End Class
