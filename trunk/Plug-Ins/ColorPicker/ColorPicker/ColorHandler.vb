Imports System.Drawing

Public Class ColorHandler

    Public Structure RGB

        Dim Red As Integer
        Dim Green As Integer
        Dim Blue As Integer

        Public Sub New(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer)
            Red = R
            Green = G
            Blue = B
        End Sub

    End Structure

    Public Structure HSV

        Dim Hue As Integer
        Dim Saturation As Integer
        Dim Value As Integer

        Public Sub New(ByVal H As Integer, ByVal S As Integer, ByVal V As Integer)
            Hue = H
            Saturation = S
            Value = V
        End Sub

    End Structure

    Public Function HSVtoRGB(ByVal H As Integer, ByVal S As Integer, ByVal V As Integer) As RGB
        Return HSVtoRGB(New HSV(H, S, V))
    End Function

    Public Shared Function HSVtoColor(ByVal HSV As HSV) As Color
        Dim RGB As RGB = HSVtoRGB(HSV)
        Return Color.FromArgb(RGB.Red, RGB.Green, RGB.Blue)
    End Function

    Public Shared Function HSVtoColor(ByVal H As Integer, ByVal S As Integer, ByVal V As Integer) As Color
        Return HSVtoColor(New HSV(H, S, V))
    End Function

    Public Shared Function HSVtoRGB(ByVal HSV As HSV) As RGB

        Dim H As Decimal
        Dim S As Decimal
        Dim V As Decimal

        Dim R As Decimal
        Dim G As Decimal
        Dim B As Decimal

        H = (HSV.Hue / CDec(255) * 360) Mod 360
        S = HSV.Saturation / 255D
        V = HSV.Value / 255D

        If S = 0 Then
            R = V
            G = V
            B = V
        Else

            Dim P As Decimal
            Dim Q As Decimal
            Dim T As Decimal

            Dim FractionalSector As Decimal
            Dim SectorNumber As Integer
            Dim SectorPos As Decimal

            SectorPos = H / 60
            SectorNumber = CInt(Math.Floor(SectorPos))

            FractionalSector = SectorPos - SectorNumber

            P = V * (1 - S)
            Q = V * (1 - (S * FractionalSector))
            T = V * (1 - (S * (1 - FractionalSector)))

            Select Case SectorNumber
                Case 0
                    R = V
                    G = T
                    B = P
                Case 1
                    R = Q
                    G = V
                    B = P
                Case 2
                    R = P
                    G = V
                    B = T
                Case 3
                    R = P
                    G = Q
                    B = V
                Case 4
                    R = T
                    G = P
                    B = V
                Case 5
                    R = V
                    G = P
                    B = Q
            End Select

        End If

        Return New RGB(CInt(R * 255), CInt(G * 255), CInt(B * 255))

    End Function

    Public Shared Function RGBtoHSV(ByVal RGB As RGB) As HSV

        Dim Min As Decimal
        Dim Max As Decimal
        Dim Delta As Decimal

        Dim R As Decimal = RGB.Red / 255D
        Dim G As Decimal = RGB.Green / 255D
        Dim B As Decimal = RGB.Blue / 255D

        Dim H As Decimal
        Dim S As Decimal
        Dim V As Decimal

        Min = Math.Min(Math.Min(R, G), B)
        Max = Math.Max(Math.Max(R, G), B)
        V = Max
        Delta = Max - Min

        If Max = 0 Or Delta = 0 Then

            S = 0
            H = 0

        Else

            S = Delta / Max
            If R = Max Then
                H = (G - B) / Delta
            ElseIf G = Max Then
                H = 2 + (B - R) / Delta
            Else
                H = 4 + (R - G) / Delta
            End If

        End If

        H *= 60
        If H < 0 Then
            H += 360
        End If

        Return New HSV(CInt(H / 360 * 255), CInt(S * 255), CInt(V * 255))

    End Function

End Class
