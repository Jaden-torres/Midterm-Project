'Midterm Project'
'Jaden Torres'
'GUI Development Class'
'Sources: none'

Public Class Form1

    Dim strInput As String 'input variable gathered'
    Dim decInput As Decimal 'input variable parsed into a decimal'
    Dim OneTool As Decimal = 39.3700787 'variable used to calculate inches to meters'
    Dim TwoTool As Decimal = 39.3700787 'variable used to calculate meters to inches'
    Dim DecOneTool As Decimal ' variable to capture result of OneTool and temp'
    Dim DecTwoTool As Decimal ' variable to capture result of TwoTool and temp'
    Dim AnswerTool As Decimal 'variable to house the definite answer'
    Dim temp As Integer 'Holds input variable for compute use'
    Dim counter As Decimal = 1 'Use to handle the odd radio button error once the form loads.'
    Dim proc As Decimal 'Used to determine what radio button is pressed'


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loads form'
        Ignore.PerformClick() 'performs ignore button click'
        Ignore.Hide() 'Hides ignore button'
    End Sub

    Private Sub Inbox_TextChanged(sender As Object, e As EventArgs) Handles Inbox.TextChanged

    End Sub

    Private Sub Answer_Enter(sender As Object, e As EventArgs) Handles Answer.Enter

    End Sub

    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles Convert.Click 'This is what happens when the convert button is clicked'
        strInput = Inbox.Text 'Captures input of the Inbox'
        If Decimal.TryParse(strInput, decInput) = False And counter = 0 Then 'Parses input to decimal form, checks to see if string can be parsed'
            MsgBox("Error: Value you have entered is not numeric. Please try again")
            Inbox.ResetText() 'resets text box'
            Answer.ResetText() 'resets group box'
            Exit Sub
        Else
            If IsNumeric(strInput) = False Then 'Checks to see if input is numeric, if not then run error msg'
                MsgBox("Error: Value you have entered is not numeric. Please try again")
                Inbox.ResetText()
                Answer.ResetText()
                Exit Sub
            Else
                If decInput < 0 Then 'Checks to see if the input is negative, if negative then run error msg'
                    MsgBox("Error: Value you have entered is negative. Please try again")
                    Inbox.ResetText()
                    Answer.ResetText()
                    Exit Sub
                End If
            End If
        End If
        temp = 0 'resets temp from previous value'
        temp = decInput ' adds new value to temp'
        Compute() 'calling compute class'
    End Sub

    Private Sub Compute() 'This class runs the calculations'
        If proc = 1 Then ' if the first radio button is pressed' 
            AnswerTool = 0
            DecOneTool = Math.Round(temp / OneTool, 3)
            AnswerTool = DecOneTool
        Else
            If proc = 2 Then ' if the second radio button is pressed'
                AnswerTool = 0
                DecTwoTool = Math.Round(TwoTool * temp, 3)
                AnswerTool = DecTwoTool
            End If
        End If
        Stat_Output() ' calls stat_output class'
    End Sub

    Private Sub Stat_Output() ' formats and sends calculations to answer groupbox'
        If proc = 1 Then 'format for the first radio button option'
            Answer.Text = decInput.ToString() + " inches is " + AnswerTool.ToString() + " meters."
        Else
            If proc = 2 Then 'format for the second radio button option'
                Answer.Text = decInput.ToString() + " meters is " + AnswerTool.ToString() + " inches."
            End If
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click 'This is what happens when the clear button is pressed'
        Inbox.ResetText()
        Answer.ResetText()
        proc = 0
    End Sub

    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click ' This is what happens when the Exit button is pressed'
        Close() 'exit program'
    End Sub

    Private Sub Ignore_CheckedChanged(sender As Object, e As EventArgs) Handles Ignore.CheckedChanged 'This button is to be ignored, this helps that weird button issue off startup'
        counter = counter - 1
    End Sub

    Private Sub Option1_Click(sender As Object, e As EventArgs) Handles Option1.Click ' this is what happens when radio button one is clicked'
        proc = 1 'sets proc a value to be called on later'
    End Sub

    Private Sub Option2_Click(sender As Object, e As EventArgs) Handles Option2.Click ' this is what happens when radio button two is clicked'
        proc = 2 'sets proc a value to be called on later'
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
