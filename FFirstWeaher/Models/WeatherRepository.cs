using System.Collections.Generic;
using System.Collections.Generic;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using System.IO;
using System;
using FFirstWeaher.App_Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FFirstWeaher.Models
{
    public class WeatherRepository
    {
        List<Weather> Weathers = new List<Weather>();
        int[] years = new int[] { 2010, 2011, 2012, 2013 };

        public WeatherRepository(int year, int month)
        {
            GetData(year,month);
        }

        public void GetData(int year, int month)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (db.Weathers.ToList().Count != 0)

                {
                    Weathers = GetDataFromBD(year, month);

                }
                else
                {

                    //TODO изменить года на поиске среди файлов 
                    for (int i = 0; i < years.Length; i++)
                    {
                       GetDataFromExcel(string.Format(@"DataWeather\moskva_{0}.xlsx", year), year);
                    }
                    Weathers = GetDataFromBD(year, month);

                }

            }
        }
        public List<Weather> GetWeathers()
        {
            return Weathers;
        }
            public List<Weather> GetDataFromBD(int year, int month)
            {
           List<Weather> temp = new List<Weather>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IQueryable<Weather> weathers = db.Weathers.Include(p => p.Year);
                weathers = weathers.Where(p => p.Year == year.ToString());
                weathers = weathers.Where(p => p.Month == month.ToString());
                temp = weathers.ToList();
                return temp;
            }
            }
        


        public void GetDataFromExcel(string filePath, int year)
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
            using (ApplicationContext db = new ApplicationContext())
            {
                for (int she = 0; she < Workbook.NumberOfSheets; she++)
                {
                    // Находим на первом листе
                    ISheet sheet = Workbook.GetSheetAt(she);

                    // Первая строка - это строка заголовка

                    for (int i = 4; i <= sheet.LastRowNum; i++)
                    {

                        IRow headerRow = sheet.GetRow(i);
                        int cellCount = headerRow.LastCellNum;// Номер первой строки и столбца
                                                              // Общее количество столбцов
                        IRow row = sheet.GetRow(i);
                        DataRow dataRow = table.NewRow();

                        List<string> vs = new List<string>();
                        
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
                        db.Weathers.Add(weather);
                        
                    }
                    
                }
                db.SaveChanges();
                
            }
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