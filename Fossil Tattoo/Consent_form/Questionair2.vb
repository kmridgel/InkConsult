Public Class Questionair2
    Public saveinfo2(18) As String
    Private Sub Questionair1e_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReDim saveinfo2(18)
        saveinfo2(0) = Questionair1.saveinfo(0)
        saveinfo2(1) = Questionair1.saveinfo(1)
        saveinfo2(2) = Questionair1.saveinfo(2)
        saveinfo2(3) = Questionair1.saveinfo(3)
        saveinfo2(4) = Questionair1.saveinfo(4)
        saveinfo2(5) = Questionair1.saveinfo(5)
        saveinfo2(6) = Questionair1.saveinfo(6)
        saveinfo2(7) = Questionair1.saveinfo(7)
        saveinfo2(8) = Questionair1.saveinfo(8)
        saveinfo2(9) = Questionair1.saveinfo(9)
        saveinfo2(10) = Questionair1.saveinfo(10)
        saveinfo2(11) = Questionair1.saveinfo(11)
        saveinfo2(12) = Questionair1.saveinfo(12)


        Questionair1.Close()

        saveinfo2(13) = "0"
        saveinfo2(14) = "0"
        saveinfo2(15) = "0"
        saveinfo2(16) = "0"
        saveinfo2(17) = "0"
        saveinfo2(18) = "0"
    End Sub

    Private Sub VirginSkinRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles VirginSkinRadio.CheckedChanged
        saveinfo2(13) = "virgin skin"
        HowLongLabel.Show()

        Panel2.Show()
    End Sub

    Private Sub One2ThreeTatsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles One2ThreeTatsRadio.CheckedChanged
        saveinfo2(13) = "1-3"
        HowLongLabel.Show()
        Panel2.Show()
    End Sub

    Private Sub Three2TenTatsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Three2TenTatsRadio.CheckedChanged
        saveinfo2(13) = "4-10"
        HowLongLabel.Show()
        Panel2.Show()
    End Sub

    Private Sub CoveredTatsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles CoveredTatsRadio.CheckedChanged
        saveinfo2(13) = "11 or more"
        HowLongLabel.Show()
        Panel2.Show()
    End Sub

    Private Sub ZeroMonthsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles ZeroMonthsRadio.CheckedChanged
        saveinfo2(14) = "0-6 months"
        NowLabel.Show()
        InForALabel.Show()
        Panel3.Show()
    End Sub

    Private Sub SixMonthsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles SixMonthsRadio.CheckedChanged
        saveinfo2(14) = "6 months - 2 years"
        NowLabel.Show()
        InForALabel.Show()
        Panel3.Show()
    End Sub

    Private Sub TwoYearsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles TwoYearsRadio.CheckedChanged
        saveinfo2(14) = "2-5 years"
        NowLabel.Show()
        InForALabel.Show()
        Panel3.Show()
    End Sub

    Private Sub FiveYearsRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles FiveYearsRadio.CheckedChanged
        saveinfo2(14) = "5 years or more"
        NowLabel.Show()
        InForALabel.Show()
        Panel3.Show()
    End Sub

    Private Sub NewTatRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles NewTatRadio.CheckedChanged
        saveinfo2(15) = "New tattoo"
        HowBigLabel.Show()
        InForALabel.Show()
        Panel4.Show()
    End Sub

    Private Sub CoverTatRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles CoverTatRadio.CheckedChanged
        saveinfo2(15) = "Cover-up an old tatoo"
        HowBigLabel.Show()
        Panel4.Show()
    End Sub

    Private Sub TouchUpRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles TouchUpRadio.CheckedChanged
        saveinfo2(15) = "Touch-up a previous tatoo"
        HowBigLabel.Show()
        Panel4.Show()
    End Sub

    Private Sub QuarterSizeRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles QuarterSizeRadio.CheckedChanged
        saveinfo2(16) = "Quarter"
        FullColorLabel.Show()
        Panel5.Show()
    End Sub

    Private Sub BCardSizeRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles BCardSizeRadio.CheckedChanged
        saveinfo2(16) = "Buisness Card"
        FullColorLabel.Show()
        Panel5.Show()
    End Sub

    Private Sub HalfSheetSizeRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles HalfSheetSizeRadio.CheckedChanged
        saveinfo2(16) = "Half a sheet of papaer"
        FullColorLabel.Show()
        Panel5.Show()
    End Sub

    Private Sub FullSheetSizeRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles FullSheetSizeRadio.CheckedChanged
        saveinfo2(16) = "Full sheet of paper"
        FullColorLabel.Show()
        Panel5.Show()
    End Sub

    Private Sub HalfLimbSizeRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles HalfLimbSizeRadio.CheckedChanged
        saveinfo2(16) = "Multiple locations"
        FullColorLabel.Show()
        Panel5.Show()
    End Sub

    Private Sub FullLimbSizeRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles FullLimbSizeRadio.CheckedChanged
        saveinfo2(16) = "Sleeved leg or arm"
        FullColorLabel.Show()
        Panel5.Show()
    End Sub

    Private Sub BlackGreyColorRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles BlackGreyColorRadio.CheckedChanged
        saveinfo2(17) = "Grayscale "
        BudgetLabel.Show()
        Panel6.Show()
    End Sub

    Private Sub FullColorRadio_CheckedChanged_1(sender As Object, e As EventArgs) Handles FullColorRadio.CheckedChanged
        saveinfo2(17) = "Color"
        BudgetLabel.Show()
        Panel6.Show()
    End Sub

    Private Sub Budget50Radio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Budget50Radio.CheckedChanged
        saveinfo2(18) = "$50 - $150"
        LaterLabel.Show()
    End Sub

    Private Sub Budget150Radio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Budget150Radio.CheckedChanged
        saveinfo2(18) = "$15 - $300"
        LaterLabel.Show()
    End Sub

    Private Sub Budget300Radio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Budget300Radio.CheckedChanged
        saveinfo2(18) = "$300 - $500"
        LaterLabel.Show()
    End Sub

    Private Sub Budget500Radio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Budget500Radio.CheckedChanged
        saveinfo2(18) = "$500 - $750"
        LaterLabel.Show()
    End Sub

    Private Sub Budget750Radio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Budget750Radio.CheckedChanged
        saveinfo2(18) = "$750 - $1000"
        LaterLabel.Show()
    End Sub

    Private Sub Budget1000Radio_CheckedChanged_1(sender As Object, e As EventArgs) Handles Budget1000Radio.CheckedChanged
        saveinfo2(18) = "$1000 or more"
        LaterLabel.Show()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If saveinfo2(13) = "0" Or saveinfo2(14) = "0" Or saveinfo2(15) = "0" Or saveinfo2(16) = "0" Or saveinfo2(17) = "0" Or saveinfo2(18) = "0" Then
            warningtxt.BackColor = Color.Red
            warningtxt.Text = " Please fill in all the shaded yellow areas."
            warningtxt.Show()
            My.Computer.Audio.PlaySystemSound(
           System.Media.SystemSounds.Asterisk)
        Else
            painmap.Show()
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Questionair1.Show()
        Me.Close()
    End Sub
    Private Sub GoButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoButton.MouseEnter
        GoButton.BackColor = Color.Tan
    End Sub
    Private Sub GoButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoButton.MouseLeave
        GoButton.BackColor = Color.Black

    End Sub

    Private Sub BackButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackButton.MouseEnter
        BackButton.BackColor = Color.Tan

    End Sub
    Private Sub BackButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackButton.MouseLeave
        BackButton.BackColor = Color.Black

    End Sub


End Class