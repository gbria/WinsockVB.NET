<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWinsock1 = New AxMSWinsockLib.AxWinsock()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.AxWinsock2 = New AxMSWinsockLib.AxWinsock()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWinsock2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWinsock1
        '
        Me.AxWinsock1.Enabled = True
        Me.AxWinsock1.Location = New System.Drawing.Point(160, 288)
        Me.AxWinsock1.Name = "AxWinsock1"
        Me.AxWinsock1.OcxState = CType(resources.GetObject("AxWinsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock1.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 82)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 84)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 190)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Escoltar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SERVIDOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "CLIENT"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Enviar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(300, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 33)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Connectar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(298, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(298, 82)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 84)
        Me.TextBox4.TabIndex = 6
        '
        'AxWinsock2
        '
        Me.AxWinsock2.Enabled = True
        Me.AxWinsock2.Location = New System.Drawing.Point(509, 286)
        Me.AxWinsock2.Name = "AxWinsock2"
        Me.AxWinsock2.OcxState = CType(resources.GetObject("AxWinsock2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock2.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock2.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(430, 249)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(157, 20)
        Me.TextBox5.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "IP"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(616, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 55)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "FI"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 340)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.AxWinsock2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AxWinsock1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWinsock2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWinsock1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents AxWinsock2 As AxMSWinsockLib.AxWinsock
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
