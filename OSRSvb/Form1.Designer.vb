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
        Me.urlResponseText = New System.Windows.Forms.RichTextBox()
        Me.ItemNum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.geLink = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deserialResponseTxt = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'urlResponseText
        '
        Me.urlResponseText.Location = New System.Drawing.Point(12, 197)
        Me.urlResponseText.Name = "urlResponseText"
        Me.urlResponseText.Size = New System.Drawing.Size(144, 176)
        Me.urlResponseText.TabIndex = 1
        Me.urlResponseText.Text = ""
        '
        'ItemNum
        '
        Me.ItemNum.Location = New System.Drawing.Point(12, 382)
        Me.ItemNum.Name = "ItemNum"
        Me.ItemNum.Size = New System.Drawing.Size(292, 20)
        Me.ItemNum.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pull Item Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picBox1
        '
        Me.picBox1.Location = New System.Drawing.Point(162, 12)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(113, 106)
        Me.picBox1.TabIndex = 4
        Me.picBox1.TabStop = False
        '
        'geLink
        '
        Me.geLink.AutoSize = True
        Me.geLink.Location = New System.Drawing.Point(140, 181)
        Me.geLink.Name = "geLink"
        Me.geLink.Size = New System.Drawing.Size(145, 13)
        Me.geLink.TabIndex = 5
        Me.geLink.TabStop = True
        Me.geLink.Text = "Grand Exchange Official Link"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Raw Data"
        '
        'deserialResponseTxt
        '
        Me.deserialResponseTxt.Location = New System.Drawing.Point(267, 197)
        Me.deserialResponseTxt.Name = "deserialResponseTxt"
        Me.deserialResponseTxt.Size = New System.Drawing.Size(144, 176)
        Me.deserialResponseTxt.TabIndex = 7
        Me.deserialResponseTxt.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Scraped"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 414)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.deserialResponseTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.geLink)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ItemNum)
        Me.Controls.Add(Me.urlResponseText)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents urlResponseText As RichTextBox
    Friend WithEvents ItemNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents geLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents deserialResponseTxt As RichTextBox
    Friend WithEvents Label2 As Label
End Class
