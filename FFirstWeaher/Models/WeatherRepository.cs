using System.Collections.Generic;
using System.Collections.Generic;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using System.IO;
using System;

namespace FFirstWeaher.Models
{
    public class WeatherRepository
    {
         List<WeathersForYear> Weathers = new List<WeathersForYear>();
        
       
        public WeatherRepository(int[] years)
        {
            for(int i = 0; i < years.Length; i++)
            {
                Weathers.Add(GetDataFromExcel(string.Format(@"C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\DataWeather\moskva_{0}.xlsx",years[i]),years[i]));
            }
            
        }
        public List<WeathersForYear> GetWeathers()
        {
            return Weathers;
        }

        /*public List<Weather> GetDataFromExcel(string filePath, int month, int year)
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
            ISheet sheet = Workbook.GetSheetAt(month - 1);
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

        }*/
        public WeathersForYear GetDataFromExcel(string filePath,int year)
        {
            WeathersForYear weathersForYear = new WeathersForYear();
            List<List<Weather>> weatherss = new List<List<Weather>>();
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
            for (int she = 0; she < Workbook.NumberOfSheets; she++)
            {
                // Находим на первом листе
                ISheet sheet = Workbook.GetSheetAt(she);
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

                    list.Add(weather);
                }
                weatherss.Add(list);
            }
            weathersForYear.weathersForYear = weatherss;
            weathersForYear.year = year;
            return weathersForYear;
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
