using System;

using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Airport
{
    class FileReader
    {
        

        public void GetFiles(string directory) 
        {
            var filePaths = Directory.GetFiles($@"C:\Users\eriki\Desktop\Skole\Airport\Files\{directory}");

            for (int i = 0; i < filePaths.Length; i++)
            {
                if (filePaths[i].EndsWith(".txt"))
                {
                    
                }
            }

        }

        

    }
}
