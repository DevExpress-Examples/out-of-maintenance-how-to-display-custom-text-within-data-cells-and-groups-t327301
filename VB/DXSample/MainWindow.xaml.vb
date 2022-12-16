Imports System.Windows

Namespace DXSample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            DataContext = DataHelper.GetData()
        End Sub

        Private Sub GridControl_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs)
            If Equals(e.Column.FieldName, "AccessLevel") Then
                Select Case CInt(e.Value)
                    Case 0
                        e.DisplayText = "User"
                    Case 1
                        e.DisplayText = "Moderator"
                    Case 2
                        e.DisplayText = "Administrator"
                    Case Else
                End Select
            End If
        End Sub

        Private Sub GridControl_CustomGroupDisplayText(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomGroupDisplayTextEventArgs)
            If Equals(e.Column.FieldName, "RegistrationDate") Then
                Dim val As Date = CDate(e.Value)
                e.DisplayText = val.ToString("dd-MMM-yyyy")
            End If
        End Sub
    End Class
End Namespace
