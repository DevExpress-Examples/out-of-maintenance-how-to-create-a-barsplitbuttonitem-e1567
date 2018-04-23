Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core

Namespace BarSplitButtonItem
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#1"
		Private Sub btnFontColor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			Dim pcc As PopupControlContainer = TryCast((TryCast(e.Item, DevExpress.Xpf.Bars.BarSplitButtonItem)).PopupControl, PopupControlContainer)
			Dim color As Color = (TryCast((TryCast(pcc.Content, ThemedUserControl)).Content, ColorChooser)).Color
			MessageBox.Show("Color is applied: " & color.ToString())
		End Sub
		#End Region ' #1
	End Class
End Namespace
