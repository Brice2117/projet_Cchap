using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

using _Excel= Microsoft.Office.Interop.Excel;

namespace Score_Excel
{
    class Program
    {
            string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public static void Main(string []args)
        {
            //OpenFile();
            Program excel = new Program(@"C:\Users\Utilisateur\Desktop\Score_Excel\Score_Excel\Tst.xlsx", 1);
            Console.WriteLine(excel.ReadCell(0, 0));
            Console.WriteLine("Enter Somting to set to a cell");
            string txt=Console.ReadLine();
            Console.WriteLine("Enter the row number");
            int row= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the col number");
            int col= Convert.ToInt32(Console.ReadLine());
            excel.WriteToCell(row, col, txt);
            excel.Save();
        }
        public Program(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];

        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else { return ""; }
        }

        public void WriteToCell(int i,int j,string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }
        public void Save()
        {
            wb.Save();
            wb.Close();
        }
    }
}
