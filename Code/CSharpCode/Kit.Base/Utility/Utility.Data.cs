// ----------------------------------------------------------------------------------------------------
// Copyright © Guo jin ming. All rights reserved.
// Homepage: https://kylin.app/
// E-Mail: kevin@kylin.app
// ----------------------------------------------------------------------------------------------------

using System;

namespace Kit
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class Utility
    {

        /// <summary>
        /// 数据相关处理
        /// </summary>
        public static class Data
        {
            private readonly static string[] CsvRowSplit = new string[] { "\r\n" };
            private readonly static string[] CsvColumnSplit = new string[] { "," };

            #region ... Text

            #region ... Csv

            /// <summary>
            /// 分割数据 安装多行分割成一行一行 CSV 
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string[] SplitDataRowByTextCsv(string text)
            {
                if (string.IsNullOrEmpty(text))
                {
                    return default(string[]);
                }
                return text.Split(CsvRowSplit, StringSplitOptions.None);
            }

            /// <summary>
            /// 分割数据 按照一行CSV数据切割 单个数据
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string[] SplitDataColumnByTextCsvOneRow(string text)
            {
                if (string.IsNullOrEmpty(text))
                {
                    return default(string[]);
                }
                return text.Split(CsvColumnSplit, StringSplitOptions.None);
            }

            #endregion

            #endregion
             
        }

    }
}