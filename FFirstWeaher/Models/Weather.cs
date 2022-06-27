using System.Collections.Generic;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using System.IO;
using System;

namespace FFirstWeaher.Models
{
    public class Weather
    {
        
        public string Date { get; set; }
        public string Time { get; set; }
        public string T { get; set; }
        public string Vlaga { get; set; }
        public string Td { get; set; }
        public string Ps { get; set; }
        public string NaprVet { get; set; }
        public string SpeedVetra { get; set; }
        public string Oblach { get; set; }
        public string h { get; set; }
        public string VV { get; set; }
        public string pogoda { get; set; }
        public Weather()
        {

        }
        public Weather(List<string> nn)
        {
            
                Date = nn[0];
                Time = nn[1];
                T = nn[2];
                Vlaga = nn[3];
                Td = nn[4];
                Ps=nn[5];
                NaprVet = nn[6];
                SpeedVetra=nn[7];
                Oblach = nn[8];
                h= nn[9];
                VV=nn[10];
                pogoda = nn[11]; 
            
        }
    }
    public class Weathers{
        
        List<List<Weather>> weatherss = new List<List<Weather>>();
       public List<Weather> weathers = new List<Weather>();
        //Данные на следующие книги 
       public int month { get; set; }
       public int year { get; set; }
        
        public void GetDataFromExcel(string filePath)
        {
            IWorkbook Workbook;
            DataTable table = new DataTable();
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // XSSFWorkbook подходит для формата XLSX, HSSFWorkbook подходит для формата XLS
                    string fileExt = Path.GetExtension(filePath).ToLower();
                    if (fileExt == ".xls")
                    {
                        Workbook = new HSSFWorkbook(fileStream);
                    }
                    else if (fileExt == ".xlsx")
                    {
                        Workbook = new XSSFWorkbook(fileStream);
                    }
                    else
                    {
                        Workbook = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            for(int she=0; she<Workbook.NumberOfSheets; she++) { 
            // Находим на первом листе
            ISheet sheet = Workbook.GetSheetAt(she);
                List<Weather> list = new List<Weather>();
                // Первая строка - это строка заголовка

                for (int i=4;i<=sheet.LastRowNum;i++){
               
            IRow headerRow = sheet.GetRow(i);
            int cellCount = headerRow.LastCellNum;// Номер первой строки и столбца
            // Общее количество столбцов
                                            
            
                IRow row = sheet.GetRow(i);
                DataRow dataRow = table.NewRow();
                
                List<string> vs = new List<string>();
                    if (list.Count == 63) {
                        Console.WriteLine();
                    }
                if (row != null)
                {

                    for (int z = row.FirstCellNum; z < cellCount; z++)
                    {
                        if (row.GetCell(z) != null)
                        {
                            vs.Add( GetCellValue(row.GetCell(z)));
                        }
                    }
                        if (vs.Count < 12) { vs.Add(""); }
                }
                Weather weather = new Weather(vs);
                
                list.Add(weather);
            }
                weatherss.Add(list);
            }
        }
        public List<Weather> GetDataFromExcel(string filePath,int month,int year)
        {
            IWorkbook Workbook;
            DataTable table = new DataTable();
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // XSSFWorkbook подходит для формата XLSX, HSSFWorkbook подходит для формата XLS
                    string fileExt = Path.GetExtension(filePath).ToLower();
                    if (fileExt == ".xls")
                    {
                        Workbook = new HSSFWorkbook(fileStream);
                    }
                    else if (fileExt == ".xlsx")
                    {
                        Workbook = new XSSFWorkbook(fileStream);
                    }
                    else
                    {
                        Workbook = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
                // Находим на первом листе
                ISheet sheet = Workbook.GetSheetAt(month-1);
                List<Weather> list = new List<Weather>();
                // Первая строка - это строка заголовка

                for (int i = 4; i <= sheet.LastRowNum; i++)
                {

                    IRow headerRow = sheet.GetRow(i);
                    int cellCount = headerRow.LastCellNum;// Номер первой строки и столбца
                                                          // Общее количество столбцов


                    IRow row = sheet.GetRow(i);
                    DataRow dataRow = table.NewRow();

                List<string> vs = new List<string>();
                if (list.Count == 63)
                    {
                        Console.WriteLine();
                    }
                    if (row != null)
                    {

                        for (int z = row.FirstCellNum; z < cellCount; z++)
                        {
                            if (row.GetCell(z) != null)
                            {
                                vs.Add(GetCellValue(row.GetCell(z)));
                            }
                        }
                        if (vs.Count < 12) { vs.Add(""); }
                    }
                    Weather weather = new Weather(vs);

                weathers.Add(weather);
                }
            return weathers;
            
        }
        private static string GetCellValue(ICell cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }

            switch (cell.CellType)
            {
                case CellType.Blank:
                    return string.Empty;
                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
                case CellType.Numeric:
                case CellType.Unknown:
                default:
                    return cell.ToString();
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Formula:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);

                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
            }
        }
    }
}

