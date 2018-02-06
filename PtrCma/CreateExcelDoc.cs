using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PtrCma
{
    class CreateExcelDoc
    {
        private Microsoft.Office.Interop.Excel.Application app = null;
        private Microsoft.Office.Interop.Excel.Workbook workbook = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet1 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet2 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet3 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet4 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet5 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet6 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet7 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet8 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet9 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet10 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet11 = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet12 = null;
        private Microsoft.Office.Interop.Excel.Range workSheet_range = null;
        public CreateExcelDoc()
        {
            createDoc();
        }
        public void createDoc()
        {
            try
            {
                app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;
                workbook = app.Workbooks.Add(1);
                worksheet9 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                worksheet9.Name = "Assessement of Working Capital";
                // worksheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[2];
                worksheet10 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet10.Name = "As per Nayak Commitee";
                worksheet11 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet11.Name = "Calculation of drawing power";
                worksheet8 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet8.Name = "Fundflow (Detailed)";
                worksheet7 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet7.Name = "ABF Assessment";
                worksheet6 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet6.Name = "Inventory and receivables";
                worksheet5 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet5.Name = "Performance and financial";
                worksheet4 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet4.Name = "Valid";
                worksheet3 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet3.Name = "Assets";
                worksheet2 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet2.Name = "Liabilities Statement";
                worksheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet1.Name = "Gross";
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet.Name = "Client Information";
            }
            catch (Exception e)
            {
                Console.Write("Error"+e.ToString());
            }
            finally
            {
            }
        }
        public void ShowApp()
        {
            try
            {
               app.Visible = true;
            }
            catch (Exception e)
            {
                Console.Write("Error");
            }
            finally
            {
            }
        }
        public void addSheet(String wkname)
        {
            try
            {
                var newSheet = workbook.Worksheets.Add(Type.Missing, workbook.Sheets.Count,1, XlSheetType.xlWorksheet) as Worksheet;
                newSheet.Name = wkname;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
            }
        }

        public void createHeaders(int row, int col, string htext, string cell1,
        string cell2, int mergeColumns, string b, bool font, int size, string
        fcolor)
        {
            worksheet.Cells[row, col] = htext;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            workSheet_range.Merge(mergeColumns);
            switch (b)
            {
                case "YELLOW":
                    workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb();
                    break;
                case "GRAY":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                    break;
                case "GAINSBORO":
                    workSheet_range.Interior.Color =
            System.Drawing.Color.Gainsboro.ToArgb();
                    break;
                case "Turquoise":
                    workSheet_range.Interior.Color =
            System.Drawing.Color.Turquoise.ToArgb();
                    break;
                case "PeachPuff":
                    workSheet_range.Interior.Color =
            System.Drawing.Color.PeachPuff.ToArgb();
                    break;
                default:
                    //  workSheet_range.Interior.Color = System.Drawing.Color..ToArgb();
                    break;
            }

          //  workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.Font.Bold = font;
            workSheet_range.ColumnWidth = size;
            if (fcolor.Equals(""))
            {
                workSheet_range.Font.Color = System.Drawing.Color.White.ToArgb();
            }
            else
            {
                workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
            }
        }

        public void addData(int row, int col, string data)
        {
            worksheet.Cells[row, col] = data;
            worksheet.Cells[row, col].HorizontalAlignment= Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            worksheet.Columns.AutoFit();
        }


        public void createHeadersGross(int row, int col, string htext, string cell1,
        string cell2, int mergeColumns, string b, bool font, int size, string
        fcolor, int worksheetNo)
        {
            switch (worksheetNo)
            {
                case 1:
                    worksheet1.Cells[row, col] = htext;
                    break;
                case 2:
                    worksheet2.Cells[row, col] = htext;
                    break;
                case 3:
                    worksheet3.Cells[row, col] = htext;
                    break;
                case 4:
                    worksheet4.Cells[row, col] = htext;
                    break;
                case 5:
                    worksheet5.Cells[row, col] = htext;
                    break;
                case 6:
                    worksheet6.Cells[row, col] = htext;
                    break;
                case 7:
                    worksheet7.Cells[row, col] = htext;
                    break;
                case 8:
                    worksheet8.Cells[row, col] = htext;
                    break;
                case 9:
                    worksheet9.Cells[row, col] = htext;
                    break;
                case 10:
                    worksheet10.Cells[row, col] = htext;
                    break;
                case 11:
                    worksheet11.Cells[row, col] = htext;
                    break;
                case 12:
                    worksheet12.Cells[row, col] = htext;
                    break;
                default:
                    break;
            }
        }

        public void addDataGross(int row, int col, string data,int worksheetNo)
        {
            switch (worksheetNo)
            {
                case 1:
                    worksheet1.Cells[row, col] = data;
                    worksheet1.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet1.Columns.AutoFit();
                    break;
                case 2:
                    worksheet2.Cells[row, col] = data;
                    worksheet2.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet2.Columns.AutoFit();
                    break;
                case 3:
                    worksheet3.Cells[row, col] = data;
                    worksheet3.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet3.Columns.AutoFit();
                    break;
                case 4:
                    worksheet4.Cells[row, col] = data;
                    worksheet4.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet4.Columns.AutoFit();
                    break;
                case 5:
                    worksheet5.Cells[row, col] = data;
                    worksheet5.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet5.Columns.AutoFit();
                    break;
                case 6:
                    worksheet6.Cells[row, col] = data;
                    worksheet6.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet6.Columns.AutoFit();
                    break;
                case 7:
                    worksheet7.Cells[row, col] = data;
                    worksheet7.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet7.Columns.AutoFit();
                    break;
                case 8:
                    worksheet8.Cells[row, col] = data;
                    worksheet8.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet8.Columns.AutoFit();
                    break;
                case 9:
                    worksheet9.Cells[row, col] = data;
                    worksheet9.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet9.Columns.AutoFit();
                    break;
                case 10:
                    worksheet10.Cells[row, col] = data;
                    worksheet10.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet10.Columns.AutoFit();
                    break;
                case 11:
                    worksheet11.Cells[row, col] = data;
                    worksheet11.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet11.Columns.AutoFit();
                    break;
                case 12:
                    worksheet12.Cells[row, col] = data;
                    worksheet12.Cells[row, col].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet12.Columns.AutoFit();
                    break;
                default:
                    break;
            }
            
            // worksheet.Rows[row].Cells[col].SplitCell(3, 2);
            //workSheet_range = worksheet.get_Range(cell1, cell2);
            //workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            //workSheet_range.NumberFormat = format;
        }

        public void splitCell(int row, int col, int rowNum)
        {
            worksheet.Rows[row].Cells[col].SplitCell(row, rowNum);
        }
    }
}
