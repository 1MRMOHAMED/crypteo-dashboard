Public Class Dashboard

#Region "Dashboard Events"

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click, BunifuTileButton5.Click, BunifuTileButton4.Click, BunifuTileButton3.Click, BunifuTileButton2.Click, BunifuTileButton1.Click

        ' This allows the indicator to be positioned righ where the clicked BunifuTileButton is in the form.
        ' Notice that the X coordinate does not change; however, the Y coordinate changes as the position being changed is the vertical one.
        ' We have set the Y coordinate to add to the width of the currently clicked BunifuTileButton in order for the position to be in-line with the control.
        indicator.Location = New Point(indicator.Location.X, CType(sender, Bunifu.Framework.UI.BunifuTileButton).Location.Y + 71)

    End Sub

    Private Sub BunifuCustomLabel11_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel12.Click, BunifuCustomLabel11.Click

        ' This will firstly off reset the colors of the two Tab labels to the default inactive color.
        BunifuCustomLabel11.ForeColor = Color.FromArgb(136, 144, 157)
        BunifuCustomLabel12.ForeColor = Color.FromArgb(136, 144, 157)

        ' This will then set the location of the Tab indicator based on the currently clicked BunifuCustomLabel location (X coordinate).
        tab_indicator.Location = New Point(CType(sender, Bunifu.Framework.UI.BunifuCustomLabel).Location.X, tab_indicator.Location.Y)

        ' Thereafter, we can set the width of the tab inidicator to fit the width of the BunifuCustomLabel clicked. (This is however optional)
        tab_indicator.Width = CType(sender, Bunifu.Framework.UI.BunifuCustomLabel).Width + 3

        ' We can then finally change the color of the BunifuCustomLabel clicked to Black to indicate that's it's currently on focus.
        CType(sender, Bunifu.Framework.UI.BunifuCustomLabel).ForeColor = Color.Black

    End Sub

#End Region

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Let's make it easier to add years to our combobox control.
        ' We'll use a For...Loop for this.
        ' We begin from the year 1950 till to date.
        For i = 1950 To DateTime.Now.Year

            ComboBox3.Items.Add(i)

        Next

    End Sub

End Class
