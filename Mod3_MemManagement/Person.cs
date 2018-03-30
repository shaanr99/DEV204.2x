using System;
using System.IO;

namespace Mod3_MemManagement
{
    public class Person : IDisposable
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // flag to check if the object has been disposed
        private bool disposed = false;

        StreamReader sr;
        StreamWriter outputFile;

        // a file is an UNMANAGED resource
        public void ReadDetails(string fileName)
        {
            sr = new StreamReader(fileName);

            try
            {   // Open the text file using a stream reader
                using (sr){
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }

        }
        public bool WriteDetails(string fileName)
        {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            // Create a string array with the lines of text
            string[] lines = { this.PersonID.ToString(), this.FirstName, this.LastName, this.Gender, this.Age.ToString() };

            try
            {
                using (outputFile)
                {
                    foreach(string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                    result = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("This file could not be written");
                Console.WriteLine(e.Message);
                result = false;
            }
            finally
            {
                outputFile.Close();
                outputFile = null;
            }

            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }
            disposed = true;
        }
    }
}
