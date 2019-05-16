using System;
using System.IO;

namespace FARD.Data.Infraestructure
{
    public class DataResult
    {
        public bool Success { get; set; }
        public dynamic Data { get; set;}

        public void LogError (Exception ex)
        {
            this.Success = false;
            this.Data = ex.Message;

            using (StreamWriter writetext = new StreamWriter("log.txt"))
            {
                writetext.WriteLine(ex.Message);
            }
        }
    }
}
