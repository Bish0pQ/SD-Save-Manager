using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Save_Manager
{
    public abstract class MainController
    {
        public static Tuple<bool, string> FindSaveGame()
        {
            double steamId = 0;
            string drive = Environment.GetFolderPath(Environment.SpecialFolder.Windows).Substring(0, 3);
            string searchPath = $"{drive}Users\\{Environment.UserName}\\Documents\\Stranded Deep\\Data\\";

            try
            {
                //Find directories in data path
                string[] dirList = Directory.GetDirectories(searchPath);

                // Check which directory is a parsable number (the steam ID)
                for (int i = 0; i < dirList.Count(); i++)
                {
                    if (double.TryParse(dirList[i].Replace(searchPath, ""), out steamId))
                    {
                        //Parse success, found savegame path
                        return Tuple.Create(true, $"{searchPath}\\{steamId}\\{steamId}.json");
                    }
                    else
                    {
                        return Tuple.Create(false, string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {

                return Tuple.Create(false, "An error has occurred. It has been logged.");
            }

            return Tuple.Create(false, string.Empty);
        }

       
    }
}
