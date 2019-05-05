Public Class SLAU

    Dim A7, B7, C7, D7, E7, F7, A14, B14, C14, D14, E14, F14, A28, B28, C28, D28, E28, F28, A21, B21, C21, D21, E21, F21, A31, B31, C31, D31, E31, F31, A45, B45, C45, D45, E45, F45, A38, B38, C38, D38, E38, F38, A56, B56, C56, D56, E56, F56, A49, B49, C49, D49, E49, F49, A61, B61, C61, D61, E61, F61 As Double
    Dim A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5, F1, F2, F3, F4, F5 As Double
    Dim H, H1, H2, H3, H4, H5, H6, H7, H8, H9 As Double
    Dim P1, P2, P3, P4, P5 As Double
    Dim X1, X2, X3, X4, X5 As Double

    Private Sub BtnFunction_Click(sender As Object, e As EventArgs) Handles BtnFunction.Click
        A1 = KF11.Text
        A2 = KF21.Text
        A3 = KF31.Text
        A4 = KF41.Text
        A5 = KF51.Text

        B1 = KF12.Text
        B2 = KF22.Text
        B3 = KF32.Text
        B4 = KF42.Text
        B5 = KF52.Text

        C1 = KF13.Text
        C2 = KF23.Text
        C3 = KF33.Text
        C4 = KF43.Text
        C5 = KF53.Text

        D1 = KF14.Text
        D2 = KF24.Text
        D3 = KF34.Text
        D4 = KF44.Text
        D5 = KF54.Text

        E1 = KF15.Text
        E2 = KF25.Text
        E3 = KF35.Text
        E4 = KF45.Text
        E5 = KF55.Text

        F1 = Bt1.Text
        F2 = Bt2.Text
        F3 = Bt3.Text
        F4 = Bt4.Text
        F5 = Bt5.Text


        H = -(A2 / A1)
        A7 = (H * A1) + A2
        B7 = (H * B1) + B2
        C7 = (H * C1) + C2
        D7 = (H * D1) + D2
        E7 = (H * E1) + E2
        F7 = (H * F1) + F2

        H1 = -(A3 / A2)
        A14 = (H1 * A2) + A3
        B14 = (H1 * B2) + B3
        C14 = (H1 * C2) + C3
        D14 = (H1 * D2) + D3
        E14 = (H1 * E2) + E3
        F14 = (H1 * F2) + F3

        H2 = -(A4 / A3)
        A21 = (H2 * A3) + A4
        B21 = (H2 * B3) + B4
        C21 = (H2 * C3) + C4
        D21 = (H2 * D3) + D4
        E21 = (H2 * E3) + E4
        F21 = (H2 * F3) + F4

        H3 = -(A5 / A4)
        A28 = (H3 * A4) + A5
        B28 = (H3 * B4) + B5
        C28 = (H3 * C4) + C5
        D28 = (H3 * D4) + D5
        E28 = (H3 * E4) + E5
        F28 = (H3 * F4) + F5

        H4 = -(B14 / B7)
        A31 = (H4 * A7) + A14
        B31 = (H4 * B7) + B14
        C31 = (H4 * C7) + C14
        D31 = (H4 * D7) + D14
        E31 = (H4 * E7) + E14
        F31 = (H4 * F7) + F14

        H5 = -(B21 / B14)
        A38 = (H5 * A14) + A21
        B38 = (H5 * B14) + B21
        C38 = (H5 * C14) + C21
        D38 = (H5 * D14) + D21
        E38 = (H5 * E14) + E21
        F38 = (H1 * F14) + F21

        H6 = -(B28 / B21)
        A45 = (H6 * A21) + A28
        B45 = (H6 * B21) + B28
        C45 = (H6 * C21) + C28
        D45 = (H6 * D21) + D28
        E45 = (H6 * E21) + E28
        F45 = (H6 * F21) + F28

        H7 = -(C38 / C31)
        A49 = (H7 * A31) + A38
        B49 = (H7 * B31) + B38
        C49 = (H7 * C31) + C38
        D49 = (H7 * D31) + D38
        E49 = (H7 * E31) + E38
        F49 = (H7 * F31) + F38

        H8 = -(C45 / C38)
        A56 = (H8 * A38) + A45
        B56 = (H8 * B38) + B45
        C56 = (H8 * C38) + C45
        D56 = (H8 * D38) + D45
        E56 = (H8 * E38) + E45
        F56 = (H8 * F38) + F45

        H9 = -(D56 / D49)
        A61 = (H9 * A49) + A56
        B61 = (H9 * B49) + B56
        C61 = (H9 * C49) + C56
        D61 = (H9 * D49) + D56
        E61 = (H9 * E49) + E56
        F61 = (H9 * F49) + F56



        X5 = F61 / E61
        X4 = (F56 - E56 * X5) / D56
        X3 = (F45 - D45 * X4 - E45 * X5) / C45
        X2 = (F28 - C28 * X3 - D28 * X4 - E28 * X5) / B28
        X1 = (F5 - B5 * X2 - C5 * X3 - D5 * X4 - E5 * X5) / A5


        X5RES.Text = X5
        X4RES.Text = X4
        X3RES.Text = X3
        X2RES.Text = X2
        X1RES.Text = X1
    End Sub

    Private Sub Btn_Check_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        P1 = (X1 * A1) + (X2 * B1) + (C1 * X3) + (X4 * D1) + (E1 * X5)
        P2 = (X1 * A2) + (B2 * X2) + (X3 * C2) + (D2 * X4) + (X5 * E2)
        P3 = (X1 * A3) + (X2 * B3) + (C3 * X3) + (X4 * D3) + (E3 * X5)
        P4 = (X1 * A4) + (B4 * X2) + (X3 * C4) + (D4 * X4) + (X5 * E4)
        P5 = (X1 * A5) + (B5 * X2) + (C5 * X3) + (X4 * D5) + (E5 * X5)

        TP1.Text = (P1)
        TP2.Text = (P2)
        TP3.Text = (P3)
        TP4.Text = (P4)
        TP5.Text = (P5)

    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        KF11.Text = (" ")
        KF21.Text = (" ")
        KF31.Text = (" ")
        KF41.Text = (" ")
        KF51.Text = (" ")

        KF12.Text = (" ")
        KF22.Text = (" ")
        KF32.Text = (" ")
        KF42.Text = (" ")
        KF52.Text = (" ")

        KF13.Text = (" ")
        KF23.Text = (" ")
        KF33.Text = (" ")
        KF43.Text = (" ")
        KF53.Text = (" ")

        KF14.Text = (" ")
        KF24.Text = (" ")
        KF34.Text = (" ")
        KF44.Text = (" ")
        KF54.Text = (" ")

        KF15.Text = " "
        KF25.Text = " "
        KF35.Text = " "
        KF45.Text = " "
        KF55.Text = " "

        Bt1.Text = " "
        Bt2.Text = " "
        Bt3.Text = " "
        Bt4.Text = " "
        Bt5.Text = " "

        X5RES.Text = " "
        X4RES.Text = " "
        X3RES.Text = " "
        X2RES.Text = " "
        X1RES.Text = " "

        TP1.Text = " "
        TP2.Text = " "
        TP3.Text = " "
        TP4.Text = " "
        TP5.Text = " "
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

End Class
