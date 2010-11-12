using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Util
{
    class AppHelpers
    {
        public static void statusMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static string safeDirectoryCreate(string directoryName)
        {
            try
            {
                bool safe = false;
                int x = 1;
                string dir = directoryName;

                while (!safe)
                {
                    if (System.IO.Directory.Exists(dir))
                    {
                        dir = directoryName + "_" + x;
                        x++;
                    }
                    else safe = true;
                }
                System.IO.Directory.CreateDirectory(dir);
                return dir;
            }
            catch //todo - handle permissions issue
            {
                throw;
            }
        }

        public static string safeFileName(string path,string filename)
        {
            try
            {
                string confirmed_filename = filename;
                string filename_stub = filename.Substring(0, filename.LastIndexOf("."));
                string extention = filename.Substring(filename.LastIndexOf("."),filename.Length - filename.LastIndexOf("."));

                bool safe = false;
                int x = 1;
                while (!safe)
                {
                    if(System.IO.File.Exists(System.IO.Path.Combine(path, confirmed_filename)))
                    {
                        confirmed_filename = filename_stub + "_" + x + extention;
                        x++;
                    }
                    else safe = true;
                }
                return confirmed_filename;
            }
            catch { throw; }

        }
    }
}
