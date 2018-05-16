using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentTrackerNS
{
    public class errorTracking
    {
        //Passes the error message collected and outputs to a text file StudentTrackerErrorLog.txt
        public void outputErrorToText(string error)
        {
            try
            {
                while (error !=null)
                {
                    StreamWriter sw = new StreamWriter(@"C:\\Users\PHILO\My Documents\StudentTrackerErrorLog.txt");
                    sw.WriteLine(DateTime.Now + ": Error has occured code: " + error);
                    sw.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error when writing to file");
            }
        }
    }
}
