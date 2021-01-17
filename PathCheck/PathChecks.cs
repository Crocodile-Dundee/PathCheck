using System;
using System.Collections.Generic;
using System.Text;

namespace PathCheck
{
    public static class PathChecks
    {
        static PathChecks()
        {
            SelectedPath = null;
        }


        public static string SelectedPath { get; set; }


    }
}
