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
Imports DevExpress.Wpf.Bars
Imports DevExpress.Wpf.Editors
Imports DevExpress.Wpf.Core

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
		Private Sub btnFontColor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			Dim pcc As PopupControlContainer = TryCast((TryCast(e.Item, DevExpress.Wpf.Bars.BarSplitButtonItem)).PopupControl, PopupControlContainer)
			Dim color As Color = (TryCast((TryCast(pcc.Content, ThemedUserControl)).Content, ColorChooser)).Color
			MessageBox.Show("Color is applied: " & color.ToString())
		End Sub
		#End Region ' #1
	End Class
End Namespace
