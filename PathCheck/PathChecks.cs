using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace PathCheck
{
    public static class PathChecks
    {
        enum ElementType
        {
            Directory,
            File
        }

        enum ElementState
        {
            OK,
            Critical,
            Exceeded
        }


        static PathChecks()
        {
            SelectedDir = null;

            TotalElementsCount = 0;
            CriticalElementsCount = 0;
            ExceededElementsCount = 0;
        }


        /// <summary>
        /// Selected Path to be analyse
        /// </summary>
        public static string SelectedDir { get; set; }

        /// <summary>
        /// Path length from which the element should be shown as critical
        /// </summary>
        public static int CriticalLength { get; set; }

        /// <summary>
        /// Path length from which the element should be shown as exceeded
        /// </summary>
        public static int ExceededLength { get; set; }

        /// <summary>
        /// Data table which contains the result
        /// </summary>
        public static DataTable AnalyseResultTable { get; set; }
        
        /// <summary>
        /// Total element count in the selected directory
        /// </summary>
        public static int TotalElementsCount { get; set; }

        /// <summary>
        /// Count of critical elements 
        /// </summary>
        public static int CriticalElementsCount { get; set; }

        /// <summary>
        /// Count of exceeded elements
        /// </summary>
        public static int ExceededElementsCount { get; set; }



        /// <summary>
        /// Analyses the selected directory
        /// </summary>
        /// <param name="selectedDir">Selected Directory</param>
        /// <returns></returns>
        public static bool AnalyseSelectedDir(string selectedDir)
        {
            // Config result data table
            AnalyseResultTable = new DataTable();
            AnalyseResultTable.Columns.Add("ElementType", typeof(ElementType));
            AnalyseResultTable.Columns.Add("ElementPath", typeof(string));
            AnalyseResultTable.Columns.Add("ElementLength", typeof(int));
            AnalyseResultTable.Columns.Add("ElementState", typeof(ElementState));

            // Reset counts
            TotalElementsCount++;
            CriticalElementsCount++;
            ExceededElementsCount++;

            // Table of elements
            GetAllElemnts(selectedDir);

            // Loop through all elements in the list and fill data table
            for (int i = 0; i < AnalyseResultTable.Rows.Count; i++)
            {
                ElementState state;

                if (Convert.ToInt32(AnalyseResultTable.Rows[i][2]) < CriticalLength)
                {
                    state = ElementState.OK;
                }
                else if ((Convert.ToInt32(AnalyseResultTable.Rows[i][2]) >= CriticalLength) 
                      && (Convert.ToInt32(AnalyseResultTable.Rows[i][2]) < ExceededLength)) 
                {
                    state = ElementState.Critical;
                }
                else
                {
                    state = ElementState.Exceeded;
                }

                AnalyseResultTable.Rows[i][3] = state;
            }

            return true;
        }


        private static void GetAllElemnts(string selectedDir)
        {
            string[] directories = Directory.GetDirectories(selectedDir);

            foreach (string directory in directories)
            {
                AnalyseResultTable.Rows.Add(ElementType.Directory, directory, directory.Length, null);
                TotalElementsCount++;

                string[] files = Directory.GetFiles(directory);
                foreach(string file in files)
                {
                    AnalyseResultTable.Rows.Add(ElementType.Directory, file, file.Length, null);
                    TotalElementsCount++;
                }

                GetAllElemnts(directory);
            }
        }


    }
}
