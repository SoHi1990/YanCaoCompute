using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ResultCount:ComputerResult
    {
        public override DataTable GetResult(DataTable table, DataTable resultTable, decimal range)
        {
            for (int i = 1; i < table.Rows.Count; i++)
            {
                //遍历每一行
                DataRow resultDr = resultTable.Rows[i];
                DataRow dr = table.Rows[i];
                DataRow perDr = table.Rows[i - 1];
                bool positiveNum;
                //遍历列
                for (int j = 1; j < dr.Table.Columns.Count; j++)
                {
                    //取出同一价格区间的当前月份和上一月份的价格
                    Decimal num = Convert.ToDecimal(dr[j]);
                    Decimal perNum = Convert.ToDecimal(perDr[j]);
                    if (num == perNum)
                        continue;

                    positiveNum = num > perNum ? true : false;
                    //
                    decimal thisPrice = Convert.ToDecimal(table.Columns[j].ToString());
                    for (int k = 1; k < dr.Table.Columns.Count; k++)
                    {
                        decimal price = Convert.ToDecimal(table.Columns[k].ToString());
                        if (price < thisPrice - range || price > thisPrice + range)
                            continue;

                        if (k == j)
                            continue;

                        Decimal selNum = Convert.ToDecimal(dr[k]);
                        Decimal perselNum = Convert.ToDecimal(perDr[k]);
                        if (selNum == perselNum)
                            continue;

                        //增减异向，设为1
                        if (selNum - perselNum > 0 != positiveNum)
                        {
                            resultDr[k] = Convert.ToDecimal(resultDr[k]) + 1;
                        }
                    }
                }
            }
            return resultTable;
        }
    }
}
