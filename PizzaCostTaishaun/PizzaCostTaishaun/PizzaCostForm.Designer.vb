<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaCostForm
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
        Me.LblDiameter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.LblAnswer = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TxtNumDia = New System.Windows.Forms.TextBox()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.LblAnswer2Sub = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblDiameter
        '
        Me.LblDiameter.AutoSize = True
        Me.LblDiameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiameter.Location = New System.Drawing.Point(56, 120)
        Me.LblDiameter.Name = "LblDiameter"
        Me.LblDiameter.Size = New System.Drawing.Size(171, 31)
        Me.LblDiameter.TabIndex = 0
        Me.LblDiameter.Text = "Diameter (m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(590, 106)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(134, 62)
        Me.BtnCalculate.TabIndex = 2
        Me.BtnCalculate.Text = "Calculate "
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'LblAnswer
        '
        Me.LblAnswer.AutoSize = True
        Me.LblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswer.Location = New System.Drawing.Point(467, 311)
        Me.LblAnswer.Name = "LblAnswer"
        Me.LblAnswer.Size = New System.Drawing.Size(95, 24)
        Me.LblAnswer.TabIndex = 3
        Me.LblAnswer.Text = "Answer = "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(190, 301)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(163, 31)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total cost = "
        '
        'TxtNumDia
        '
        Me.TxtNumDia.Location = New System.Drawing.Point(345, 131)
        Me.TxtNumDia.Name = "TxtNumDia"
        Me.TxtNumDia.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumDia.TabIndex = 5
        '
        'LblSubtotal
        '
        Me.LblSubtotal.AutoSize = True
        Me.LblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtotal.Location = New System.Drawing.Point(190, 392)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(137, 31)
        Me.LblSubtotal.TabIndex = 6
        Me.LblSubtotal.Text = "Subtotal ="
        '
        'LblAnswer2Sub
        '
        Me.LblAnswer2Sub.AutoSize = True
        Me.LblAnswer2Sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswer2Sub.Location = New System.Drawing.Point(467, 392)
        Me.LblAnswer2Sub.Name = "LblAnswer2Sub"
        Me.LblAnswer2Sub.Size = New System.Drawing.Size(90, 24)
        Me.LblAnswer2Sub.TabIndex = 7
        Me.LblAnswer2Sub.Text = "Answer ="
        '
        'PizzaCostForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblAnswer2Sub)
        Me.Controls.Add(Me.LblSubtotal)
        Me.Controls.Add(Me.TxtNumDia)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.LblAnswer)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblDiameter)
        Me.Name = "PizzaCostForm"
        Me.Text = "Pizza Cost "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDiameter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents LblAnswer As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents TxtNumDia As TextBox
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents LblAnswer2Sub As Label
End Class
