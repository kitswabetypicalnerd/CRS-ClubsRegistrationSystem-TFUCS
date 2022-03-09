


Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VbconnectionfinalDataSet.tbl1' table. You can move, or remove it, as needed.
        Me.Tbl1TableAdapter.Fill(Me.VbconnectionfinalDataSet.tbl1)

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer



        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                    DataGridView1(j, i).Value.ToString()



            Next
        Next
        xlWorkSheet.SaveAs("C:\Users\fevro\source\repos\Clubs Registration System\ExportExcelClubs\JournalismClubExcelDatabase.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()




        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("C:\Users\fevro\source\repos\Clubs Registration System\ExportExcelClubs\JournalismClubExcelDatabase.xlsx")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class