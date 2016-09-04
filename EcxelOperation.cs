using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     public class EcxelOperation
     {
        private string caculateType;
        private string sourcePath;
        private string resultPath;

        public EcxelOperation(string caculateType,string sourcePath,string resultPath)
        {
            this.caculateType = caculateType;
            this.sourcePath = sourcePath;
            this.resultPath = resultPath;
        }
        //原始数据集合
        DataTable table = new DataTable();
        //处理后计算结果结合
        DataTable resultTable = new DataTable();

        /// <summary>
        /// 读取excel结果到Table中
        /// </summary>
        public void readExcel()
        {
            using (FileStream fs = File.OpenRead(sourcePath))
            {
                HSSFWorkbook wk = new HSSFWorkbook(fs);
                ISheet sheet = wk.GetSheetAt(0);   //读取当前表数据
                for (int i = 0; i <= sheet.LastRowNum; i++)  //LastRowNum 是当前表的总行数
                {
                    IRow row = sheet.GetRow(i);  //读取当前行数据
                    if (row == null)
                        continue;

                    if (i == 0)
                    {
                        for (int k = 0; k < row.LastCellNum; k++)  //LastCellNum 是当前行的总列数
                        {
                            ICell cell = row.GetCell(k);  //当前表格
                            if (cell == null)
                            {
                                table.Columns.Add("Weak", Type.GetType("System.String"));
                                resultTable.Columns.Add("Weak", Type.GetType("System.String"));
                            }
                            else
                            {
                                table.Columns.Add(cell.ToString(), Type.GetType("System.String"));
                                resultTable.Columns.Add(cell.ToString(), Type.GetType("System.String"));
                            }
                        }
                    }
                    else
                    {
                        DataRow dr = table.NewRow();
                        DataRow resultDr = resultTable.NewRow();
                        for (int k = 0; k < row.LastCellNum; k++)  //LastCellNum 是当前行的总列数
                        {
                            ICell cell = row.GetCell(k);  //当前表格
                            if (string.IsNullOrEmpty(cell.ToString()))
                            {
                                dr[k] = 0;
                            }
                            else
                            {
                                dr[k] = cell.ToString();
                            }
                            if (k == 0)
                            {
                                resultDr[k] = cell.ToString();
                            }
                            else
                            {
                                resultDr[k] = 0;
                            }
                        }
                        table.Rows.Add(dr);
                        resultTable.Rows.Add(resultDr);
                    }
                }
            }
        }

        /// <summary>
        /// 获取计算结果集
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public DataTable getData(decimal range)
        {
            ComputerResult computerResult;
            if (caculateType.Equals("1"))
            {
                computerResult = new ResultCount();
            }
            else
            {
                computerResult = new ResultDivision();
            }
            DataTable resultTable = computerResult.GetResult(table, this.resultTable, range);
            return resultTable;
        }

        /// <summary>
        /// 导出excel
        /// </summary>
        public void exportExcel(bool isSum,string numInterval)
        {
            readExcel();
            HSSFWorkbook wk = new HSSFWorkbook();
            string[] priceRange = numInterval.Split(';');
            foreach (string range in priceRange)
            {
                ISheet sheet = wk.CreateSheet(range);
                //第一行写价格
                IRow priceRow = sheet.CreateRow(0);
                DataTable resultTable = this.getData(Convert.ToDecimal(range));
                if (isSum)
                {
                    //第二行写次数
                    IRow countRow = sheet.CreateRow(1);
                    for (int i = 1; i < resultTable.Columns.Count; i++)
                    {
                        ICell pricecell = priceRow.CreateCell(i-1);  //在第一行中创建单元格
                        pricecell.SetCellValue(resultTable.Columns[i].ToString());//循环往第一行的单元格中添加数据
                        Decimal sum = 0;
                        for (int j = 0; j < resultTable.Rows.Count; j++)
                        {
                            sum += Convert.ToDecimal(resultTable.Rows[j][i]);
                        }
                        ICell countcell = countRow.CreateCell(i - 1);  //在第二行中创建单元格
                        countcell.SetCellValue(sum.ToString());//循环往第二行的单元格中添加数据
                    }
                }
                else
                {
                    for (int j = 0; j < resultTable.Rows.Count; j++)
                    {
                        IRow resultRow = sheet.CreateRow(j);
                        for (int i = 1; i < resultTable.Columns.Count; i++)
                        {
                            if (j == 0)
                            {
                                ICell pricecell = priceRow.CreateCell(i);  //在第一行中创建单元格
                                pricecell.SetCellValue(resultTable.Columns[i].ToString());//循环往第一行的单元格中添加数据
                            }
                            else
                            {
                                Decimal val = Convert.ToDecimal(resultTable.Rows[j][i-1]);
                                resultRow.CreateCell(i - 1).SetCellValue(val.ToString());
                            }
                        }
                    }
                }
            }
            try
            {
                using (FileStream fs = File.OpenWrite(resultPath))
                {
                    wk.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
                    MessageBox.Show("提示：创建成功！");
                }

            }
            catch
            {
                MessageBox.Show("请先关闭打开的excel");
            }
        }
    }
}
