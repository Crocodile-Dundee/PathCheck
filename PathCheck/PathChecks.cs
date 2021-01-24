using System;
using System.Data;
using System.IO;

namespace PathCheck
{
    /// <summary>
    /// Class to check the path properties of the elements
    /// </summary>
    public class PathChecks
    {
        /// <summary>
        /// Element Type
        /// </summary>
        public enum ElementType
        {
            Directory,
            File
        }

        /// <summary>
        /// Classification of the element length
        /// </summary>
        public enum ElementLength
        {
            OK,
            Critical,
            Exceeded
        }


        /// <summary>
        /// Singleton: Return the instance
        /// </summary>
        private static readonly PathChecks _Instance = new PathChecks();
        public static PathChecks GetInstance()
        {
            return _Instance;
        }

        /// <summary>
        /// Singleton: Private Constructor
        /// </summary>
        private PathChecks()
        {
            SelectedDir = null;

            TotalElementsCount = 0;
            CriticalElementsCount = 0;
            ExceededElementsCount = 0;
        }



        /// <summary>
        /// Selected Path to be analyse
        /// </summary>
        public string SelectedDir { get; set; }

        /// <summary>
        /// Path length from which the element should be shown as critical
        /// </summary>
        public int CriticalLength { get; set; }

        /// <summary>
        /// Path length from which the element should be shown as exceeded
        /// </summary>
        public int ExceededLength { get; set; }

        /// <summary>
        /// Data table which contains the result
        /// </summary>
        public DataTable AnalyseResultTable { get; set; }
        
        /// <summary>
        /// Total element count in the selected directory
        /// </summary>
        public int TotalElementsCount { get; set; }

        /// <summary>
        /// Count of critical elements 
        /// </summary>
        public int CriticalElementsCount { get; set; }

        /// <summary>
        /// Count of exceeded elements
        /// </summary>
        public int ExceededElementsCount { get; set; }



        /// <summary>
        /// Analyses the selected directory
        /// </summary>
        /// <param name="selectedDir">Selected Directory</param>
        /// <returns></returns>
        public void AnalyseSelectedDir(string selectedDir, int criticalLength, int exceededLength)
        {
            // Config result data table
            AnalyseResultTable = new DataTable();
            AnalyseResultTable.Columns.Add("ElementType", typeof(ElementType));
            AnalyseResultTable.Columns.Add("ElementPath", typeof(string));
            AnalyseResultTable.Columns.Add("ElementLength", typeof(int));
            AnalyseResultTable.Columns.Add("ElementState", typeof(ElementLength));

            // Reset counts
            TotalElementsCount = 0;
            CriticalElementsCount = 0;
            ExceededElementsCount = 0;

            // Get table of elements
            GetAllFiles(selectedDir);
            GetAllSubDirElements(selectedDir);

            // Loop through all elements in the list and fill data table
            for (int i = 0; i < AnalyseResultTable.Rows.Count; i++)
            {
                ElementLength lengthState = ElementLength.OK;

                if (Convert.ToInt32(AnalyseResultTable.Rows[i][2]) < criticalLength)
                {
                    lengthState = ElementLength.OK;
                }
                else if ((Convert.ToInt32(AnalyseResultTable.Rows[i][2]) >= criticalLength) 
                      && (Convert.ToInt32(AnalyseResultTable.Rows[i][2]) < exceededLength)) 
                {
                    lengthState = ElementLength.Critical;
                    CriticalElementsCount++;
                }
                else if (Convert.ToInt32(AnalyseResultTable.Rows[i][2]) >= exceededLength)
                {
                    lengthState = ElementLength.Exceeded;
                    ExceededElementsCount++;
                }

                AnalyseResultTable.Rows[i][3] = lengthState;
            }
        }


        /// <summary>
        /// Get all files of the selected directory
        /// </summary>
        /// <param name="selectedDir"></param>
        private void GetAllFiles(string selectedDir)
        {
            string[] files = Directory.GetFiles(selectedDir);
            foreach (string file in files)
            {
                AnalyseResultTable.Rows.Add(ElementType.File, file, file.Length, null);
                TotalElementsCount++;
            }
        }


        /// <summary>
        /// Get all elements of the sub directories of the selected directory
        /// </summary>
        /// <param name="selectedDir"></param>
        private void GetAllSubDirElements(string selectedDir)
        {
            if (selectedDir == null)
            {
                return;
            }


            string[] directories = Directory.GetDirectories(selectedDir);

            foreach (string directory in directories)
            {
                try
                {
                    AnalyseResultTable.Rows.Add(ElementType.Directory, directory, directory.Length, null);
                    TotalElementsCount++;

                    string[] files = Directory.GetFiles(directory);
                    foreach (string file in files)
                    {
                        AnalyseResultTable.Rows.Add(ElementType.File, file, file.Length, null);
                        TotalElementsCount++;
                    }

                    GetAllSubDirElements(directory);
                }
                catch { }
            }
        }


    }
}
