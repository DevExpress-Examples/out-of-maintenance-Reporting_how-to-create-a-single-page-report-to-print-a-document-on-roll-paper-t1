Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace SinglePageReport
	Public Class Data
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateValue As Integer
		Public Property Value() As Integer
			Get
				Return privateValue
			End Get
			Set(ByVal value As Integer)
				privateValue = value
			End Set
		End Property
		Private privateGroup As String
		Public Property Group() As String
			Get
				Return privateGroup
			End Get
			Set(ByVal value As String)
				privateGroup = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
	End Class
End Namespace
