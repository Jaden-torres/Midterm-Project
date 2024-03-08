<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Inbox = New TextBox()
        Answer = New GroupBox()
        Option1 = New RadioButton()
        Option2 = New RadioButton()
        Label3 = New Label()
        Convert = New Button()
        Clear = New Button()
        ExitProgram = New Button()
        Ignore = New RadioButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(483, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 65)
        Label1.TabIndex = 0
        Label1.Text = "Converter App"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(367, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(679, 54)
        Label2.TabIndex = 1
        Label2.Text = "Enter a value and choose conversion"
        ' 
        ' Inbox
        ' 
        Inbox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inbox.Location = New Point(1097, 274)
        Inbox.Name = "Inbox"
        Inbox.Size = New Size(265, 39)
        Inbox.TabIndex = 2
        ' 
        ' Answer
        ' 
        Answer.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Answer.Location = New Point(764, 732)
        Answer.Name = "Answer"
        Answer.Size = New Size(784, 81)
        Answer.TabIndex = 3
        Answer.TabStop = False
        Answer.Text = "GroupBox1"
        ' 
        ' Option1
        ' 
        Option1.AutoSize = True
        Option1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Option1.Location = New Point(624, 465)
        Option1.Name = "Option1"
        Option1.Size = New Size(324, 52)
        Option1.TabIndex = 4
        Option1.TabStop = True
        Option1.Text = "Inches to Meters"
        Option1.UseVisualStyleBackColor = True
        ' 
        ' Option2
        ' 
        Option2.AutoSize = True
        Option2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Option2.Location = New Point(624, 521)
        Option2.Name = "Option2"
        Option2.Size = New Size(324, 52)
        Option2.TabIndex = 5
        Option2.TabStop = True
        Option2.Text = "Meters to Inches"
        Option2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(603, 414)
        Label3.Name = "Label3"
        Label3.Size = New Size(395, 48)
        Label3.TabIndex = 6
        Label3.Text = "Convert Measurement"
        ' 
        ' Convert
        ' 
        Convert.Location = New Point(30, 929)
        Convert.Name = "Convert"
        Convert.Size = New Size(241, 94)
        Convert.TabIndex = 7
        Convert.Text = "Convert"
        Convert.UseVisualStyleBackColor = True
        ' 
        ' Clear
        ' 
        Clear.Location = New Point(483, 929)
        Clear.Name = "Clear"
        Clear.Size = New Size(241, 94)
        Clear.TabIndex = 8
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' ExitProgram
        ' 
        ExitProgram.Location = New Point(947, 929)
        ExitProgram.Name = "ExitProgram"
        ExitProgram.Size = New Size(241, 94)
        ExitProgram.TabIndex = 9
        ExitProgram.Text = "Exit"
        ExitProgram.UseVisualStyleBackColor = True
        ' 
        ' Ignore
        ' 
        Ignore.AutoSize = True
        Ignore.Location = New Point(483, 732)
        Ignore.Name = "Ignore"
        Ignore.Size = New Size(89, 29)
        Ignore.TabIndex = 10
        Ignore.TabStop = True
        Ignore.Text = "Ignore"
        Ignore.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 129)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 235)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1580, 1143)
        Controls.Add(PictureBox1)
        Controls.Add(Ignore)
        Controls.Add(ExitProgram)
        Controls.Add(Clear)
        Controls.Add(Convert)
        Controls.Add(Label3)
        Controls.Add(Option2)
        Controls.Add(Option1)
        Controls.Add(Answer)
        Controls.Add(Inbox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Inbox As TextBox
    Friend WithEvents Answer As GroupBox
    Friend WithEvents Option1 As RadioButton
    Friend WithEvents Option2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Convert As Button
    Friend WithEvents Clear As Button
    Friend WithEvents ExitProgram As Button
    Friend WithEvents Ignore As RadioButton
    Friend WithEvents PictureBox1 As PictureBox

End Class
