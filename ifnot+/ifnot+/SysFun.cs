using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ifnot_
{
    class SysFun
    {

        private void CreateRoamingFilesAndDirectory()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(appDataPath, @"ifnot+\");
            if (!CheckRoamingFolder())
                Directory.CreateDirectory(path);
                    
        }

        private bool CheckRoamingFolder()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(appDataPath, @"ifnot+\");

            if (Directory.Exists(path))
                return true;
            else
                return false;

        }

        private bool CheckRoamingFile()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(appDataPath, @"ifnot+\data.txt");

            bool check = File.Exists(path);

            return check;


        }




    }
}
