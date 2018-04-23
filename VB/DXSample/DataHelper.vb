Imports System
Imports System.Collections.ObjectModel

Namespace DXSample

    Public Class DataHelper
        Public Shared Function GetData() As ObservableCollection(Of Profile)
            Dim collection As New ObservableCollection(Of Profile)()
            collection.Add(New Profile() With {.ID = 0, .Login = "USERNAME1", .AccessLevel = 2, .RegistrationDate = New Date(2015, 12, 19)})
            collection.Add(New Profile() With {.ID = 1, .Login = "USERNAME2", .AccessLevel = 0, .RegistrationDate = New Date(2015, 12, 27)})
            collection.Add(New Profile() With {.ID = 2, .Login = "USERNAME3", .AccessLevel = 0, .RegistrationDate = New Date(2015, 12, 27)})
            collection.Add(New Profile() With {.ID = 3, .Login = "USERNAME4", .AccessLevel = 0, .RegistrationDate = New Date(2015, 12, 27)})
            collection.Add(New Profile() With {.ID = 4, .Login = "USERNAME5", .AccessLevel = 1, .RegistrationDate = New Date(2015, 12, 22)})
            collection.Add(New Profile() With {.ID = 5, .Login = "USERNAME6", .AccessLevel = 0, .RegistrationDate = New Date(2015, 12, 27)})
            collection.Add(New Profile() With {.ID = 6, .Login = "USERNAME7", .AccessLevel = 0, .RegistrationDate = New Date(2015, 12, 27)})
            collection.Add(New Profile() With {.ID = 8, .Login = "USERNAME9", .AccessLevel = 0, .RegistrationDate = New Date(2015, 12, 27)})
            collection.Add(New Profile() With {.ID = 7, .Login = "USERNAME8", .AccessLevel = 1, .RegistrationDate = New Date(2015, 12, 22)})
            Return collection
        End Function
    End Class
End Namespace
