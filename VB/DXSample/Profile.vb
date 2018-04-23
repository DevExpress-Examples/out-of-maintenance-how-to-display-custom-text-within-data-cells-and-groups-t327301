Imports DevExpress.Mvvm
Imports System

Namespace DXSample
    Public Class Profile
        Inherits BindableBase

        Public Property ID() As Integer
            Get
                Return GetProperty(Function() ID)
            End Get
            Set(ByVal value As Integer)
                SetProperty(Function() ID, value)
            End Set
        End Property
        Public Property Login() As String
            Get
                Return GetProperty(Function() Login)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Login, value)
            End Set
        End Property
        Public Property AccessLevel() As Integer
            Get
                Return GetProperty(Function() AccessLevel)
            End Get
            Set(ByVal value As Integer)
                SetProperty(Function() AccessLevel, value)
            End Set
        End Property

        Public Property RegistrationDate() As Date
            Get
                Return GetProperty(Function() RegistrationDate)
            End Get
            Set(ByVal value As Date)
                SetProperty(Function() RegistrationDate, value)
            End Set
        End Property
    End Class
End Namespace
