' Here, we're going to write the code for managing all the five steps in the verification process.
' This may require some amount of code but nevertheless, we shall get it running in a few minutes.

' This library provides us with awesome features to design our control(s) effectively.
Imports System.ComponentModel

Public Class VerificationProcess

    ' This contains an enumerable list of the verification steps to undergo.
    Public Enum VerificationSteps

        None
        First
        Second
        Third
        Fourth
        Fifth
        Finished

    End Enum

    ' This stores the selected "CurrentStep" value.
    Private current_step As VerificationSteps

    ' This gets/sets the selected step or position in the verification process.
    <Description("Set the current step or position in the verification process.")>
    Public Property CurrentStep() As VerificationSteps

        ' Get the currently set step-value for the user.
        Get

            Return current_step

        End Get

        ' Set the currently set step-value for the user.
        ' Likewise ensure the control actively previews the changes to the verification process.

        ' As you have noticed, the code is more of the same, only that some changes have been made based on the step within the process that the user is currently in.
        ' You can always add or modify the code as shown below in order to add or include better images and/or steps further.

        Set(ByVal value As VerificationSteps)

            current_step = value

            If current_step = VerificationSteps.None Then

                ' The designmode refers to the time at which the developer is modifying the control while the
                ' other mode (at runtime), refers to the time when the Dashboard is actually being previewed.
                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")

                Else

                    step_one.Image = Image.FromFile("new-step.png")
                    step_two.Image = Image.FromFile("new-step.png")
                    step_three.Image = Image.FromFile("new-step.png")
                    step_four.Image = Image.FromFile("new-step.png")
                    step_five.Image = Image.FromFile("new-step.png")

                End If

                link_one.LineColor = Color.FromArgb(209, 212, 221)
                link_two.LineColor = Color.FromArgb(209, 212, 221)
                link_three.LineColor = Color.FromArgb(209, 212, 221)
                link_four.LineColor = Color.FromArgb(209, 212, 221)

            ElseIf current_step = VerificationSteps.First Then

                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\current-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")

                Else

                    step_one.Image = Image.FromFile("current-step.png")
                    step_two.Image = Image.FromFile("new-step.png")
                    step_three.Image = Image.FromFile("new-step.png")
                    step_four.Image = Image.FromFile("new-step.png")
                    step_five.Image = Image.FromFile("new-step.png")

                End If

                link_one.LineColor = Color.FromArgb(209, 212, 221)
                link_two.LineColor = Color.FromArgb(209, 212, 221)
                link_three.LineColor = Color.FromArgb(209, 212, 221)
                link_four.LineColor = Color.FromArgb(209, 212, 221)

            ElseIf current_step = VerificationSteps.Second Then

                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\current-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")

                Else

                    step_one.Image = Image.FromFile("cleared-step.png")
                    step_two.Image = Image.FromFile("current-step.png")
                    step_three.Image = Image.FromFile("new-step.png")
                    step_four.Image = Image.FromFile("new-step.png")
                    step_five.Image = Image.FromFile("new-step.png")

                End If

                link_one.LineColor = Color.FromArgb(51, 151, 247)
                link_two.LineColor = Color.FromArgb(209, 212, 221)
                link_three.LineColor = Color.FromArgb(209, 212, 221)
                link_four.LineColor = Color.FromArgb(209, 212, 221)

            ElseIf current_step = VerificationSteps.Third Then

                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\current-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")

                Else

                    step_one.Image = Image.FromFile("cleared-step.png")
                    step_two.Image = Image.FromFile("cleared-step.png")
                    step_three.Image = Image.FromFile("current-step.png")
                    step_four.Image = Image.FromFile("new-step.png")
                    step_five.Image = Image.FromFile("new-step.png")

                End If

                link_one.LineColor = Color.FromArgb(51, 151, 247)
                link_two.LineColor = Color.FromArgb(51, 151, 247)
                link_three.LineColor = Color.FromArgb(209, 212, 221)
                link_four.LineColor = Color.FromArgb(209, 212, 221)

            ElseIf current_step = VerificationSteps.Fourth Then

                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\current-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\new-step.png")

                Else

                    step_one.Image = Image.FromFile("cleared-step.png")
                    step_two.Image = Image.FromFile("cleared-step.png")
                    step_three.Image = Image.FromFile("cleared-step.png")
                    step_four.Image = Image.FromFile("current-step.png")
                    step_five.Image = Image.FromFile("new-step.png")

                End If

                link_one.LineColor = Color.FromArgb(51, 151, 247)
                link_two.LineColor = Color.FromArgb(51, 151, 247)
                link_three.LineColor = Color.FromArgb(51, 151, 247)
                link_four.LineColor = Color.FromArgb(209, 212, 221)

            ElseIf current_step = VerificationSteps.Fifth Then

                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\current-step.png")

                Else

                    step_one.Image = Image.FromFile("cleared-step.png")
                    step_two.Image = Image.FromFile("cleared-step.png")
                    step_three.Image = Image.FromFile("cleared-step.png")
                    step_four.Image = Image.FromFile("cleared-step.png")
                    step_five.Image = Image.FromFile("current-step.png")

                End If

                link_one.LineColor = Color.FromArgb(51, 151, 247)
                link_two.LineColor = Color.FromArgb(51, 151, 247)
                link_three.LineColor = Color.FromArgb(51, 151, 247)
                link_four.LineColor = Color.FromArgb(51, 151, 247)

            ElseIf current_step = VerificationSteps.Finished Then

                If DesignMode Then

                    step_one.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_two.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_three.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_four.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")
                    step_five.Image = Image.FromFile("C:\Users\Kenboi\Pictures\UI Inspirations\Crypteo - Bitcoin  Ethereum Exchange Dashboard\Icons\cleared-step.png")

                Else

                    step_one.Image = Image.FromFile("cleared-step.png")
                    step_two.Image = Image.FromFile("cleared-step.png")
                    step_three.Image = Image.FromFile("cleared-step.png")
                    step_four.Image = Image.FromFile("cleared-step.png")
                    step_five.Image = Image.FromFile("cleared-step.png")

                End If

                link_one.LineColor = Color.FromArgb(51, 151, 247)
                link_two.LineColor = Color.FromArgb(51, 151, 247)
                link_three.LineColor = Color.FromArgb(51, 151, 247)
                link_four.LineColor = Color.FromArgb(51, 151, 247)

            End If

        End Set

    End Property

End Class
