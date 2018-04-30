using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.Common
{
    public static class FileUtils
    {
        public static string CombinePath(string path1, string path2)
        {
            try
            {
                if (string.IsNullOrEmpty(path1) || string.IsNullOrEmpty(path2))
                {
                    throw new ArgumentException("Path1 ou Path2 não são fornecidos.");
                }

                if (path1[path1.Length - 1] == '\\' ) {
                    return path1 + path2;
                } else
                {
                    return $"{path1}\\{path2}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
