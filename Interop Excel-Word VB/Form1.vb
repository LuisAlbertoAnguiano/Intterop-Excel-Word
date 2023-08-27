Imports Excel = Microsoft.Office.Interop.Excel
Imports Word = Microsoft.Office.Interop.Word

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Nombre As String = Tbx_Nombre.Text
        Dim Texto As String = Tbx_Texto.Text

        Dim path As String = Tbx_Directorio.Text & "\" & Nombre & ".xlsx"

        Dim oApp As Excel.Application
        Dim oSheet As Excel.Worksheet
        Dim oBook As Excel.Workbook
        Dim wb As Excel.Workbook
        oApp = New Excel.Application()
        oApp.Visible = True
        oBook = oApp.Workbooks.Add()
        oSheet = CType(oBook.Worksheets.Item(1), Excel.Worksheet)
        oSheet.Cells(1, 1) = Texto
        oBook.SaveAs(path)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim Nombre As String = Tbx_Nombre.Text
        Dim Texto As String = Tbx_Texto.Text

        Dim path As String = Tbx_Directorio.Text & "\" & Nombre

        Dim ObjMiss As Object = System.Reflection.Missing.Value
        Dim oApp As Word.Application = New Word.Application()
        Dim oDocument As Word.Document = oApp.Documents.Add(ObjMiss, ObjMiss, ObjMiss, ObjMiss)
        oDocument.Activate()
        oApp.Selection.TypeText(Tbx_Texto.Text)
        oApp.Visible = True
        oDocument.SaveAs2(path)
    End Sub

    Private Sub Btn_Directorio_Click(sender As Object, e As EventArgs) Handles Btn_Directorio.Click
        Dim Directorio As FolderBrowserDialog = New FolderBrowserDialog()
        DialogResult = Directorio.ShowDialog()

        If DialogResult = DialogResult.OK Then
            Tbx_Directorio.Text = Directorio.SelectedPath
        End If
    End Sub
End Class
