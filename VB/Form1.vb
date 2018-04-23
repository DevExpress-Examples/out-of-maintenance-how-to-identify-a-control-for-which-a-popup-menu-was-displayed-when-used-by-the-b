Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private button1 As System.Windows.Forms.Button
		Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.button1 = New System.Windows.Forms.Button()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(20, 21)
			Me.button1.Name = "button1"
			Me.barManager1.SetPopupContextMenu(Me.button1, Me.popupMenu1)
			Me.button1.Size = New System.Drawing.Size(127, 20)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Right-click me"
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.BarButtonItem1})
			Me.barManager1.MaxItemId = 1
'			Me.barManager1.QueryShowPopupMenu += New DevExpress.XtraBars.QueryShowPopupMenuEventHandler(Me.barManager1_QueryShowPopupMenu);
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
'			Me.popupMenu1.CloseUp += New System.EventHandler(Me.popupMenu1_CloseUp);
			' 
			' BarButtonItem1
			' 
			Me.BarButtonItem1.Caption = "BarButtonItem1"
			Me.BarButtonItem1.Id = 0
			Me.BarButtonItem1.Name = "BarButtonItem1"
'			Me.BarButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.BarButtonItem1_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(292, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 265)
			Me.barDockControlBottom.Size = New System.Drawing.Size(292, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 265)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(292, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 265)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(292, 265)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private popupControl As Control

		Private Sub barManager1_QueryShowPopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraBars.QueryShowPopupMenuEventArgs) Handles barManager1.QueryShowPopupMenu
			Console.WriteLine(e.Control)
			popupControl = e.Control
		End Sub

		Private Sub popupMenu1_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupMenu1.CloseUp
			popupControl = Nothing
		End Sub

		Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
			Console.WriteLine(e.Link.LinkedObject)
			If e.Link.LinkedObject Is popupMenu1 Then
				MessageBox.Show(String.Format("The context menu was invoked for '{0}'.", popupControl))
			End If
		End Sub
	End Class
End Namespace
