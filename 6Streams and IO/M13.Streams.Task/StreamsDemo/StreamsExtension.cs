using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace StreamsDemo
{
    // C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015
    // Chapter 15: Streams and I/O
    // Chapter 6: Framework Fundamentals - Text Encodings and Unicode
    // https://msdn.microsoft.com/ru-ru/library/system.text.encoding(v=vs.110).aspx

    public static class StreamsExtension
    {

        #region Public members

        #region TODO: Implement by byte copy logic using class FileStream as a backing store stream .

        public static int ByByteCopy(string sourcePath, string destinationPath)
        {
            if (!File.Exists(sourcePath))
                throw new ArgumentException($"File doesn't exist this path {sourcePath}.");
            else
            {
                Stream destinationStream = null;
                var byteCount = 0;
                var i = 0;
                try
                {
                    destinationStream = new FileStream(destinationPath, FileMode.Create);

                    using(Stream sourceStream = new FileStream(sourcePath, FileMode.Open))
                    {
                        while(i++ < sourceStream.Length)
                        {
                            byte writedByte = (byte)sourceStream.ReadByte();
                            destinationStream.WriteByte(writedByte);
                            byteCount++;
                        }
                    }
                }
                finally
                {
                    if (destinationStream != null)
                        destinationStream.Dispose();
                }

                return byteCount;
            }

        }

        #endregion

        #region TODO: Implement by byte copy logic using class MemoryStream as a backing store stream.

        public static int InMemoryByByteCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);

            var byteCount = 0;
            MemoryStream ms = new MemoryStream();
            using (FileStream file = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
                file.CopyTo(ms);
            using (FileStream file2 = new FileStream(destinationPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                ms.WriteTo(file2);
                byteCount = (int)file2.Length;
                
            }

            return byteCount;
        }

        #endregion

        #region TODO: Implement by block copy logic using FileStream buffer.

        public static int ByBlockCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);

            var byteCount = 0;
            FileStream file = null;
            FileStream file2 = null;
            using (file = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
                
            using (file2 = new FileStream(destinationPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                file.CopyTo(file2);
                byteCount = (int)file2.Length;
            }


            return byteCount;
        }

        #endregion

        #region TODO: Implement by block copy logic using MemoryStream.

        public static int InMemoryByBlockCopy(string sourcePath, string destinationPath)
        {
            return InMemoryByByteCopy(sourcePath, destinationPath);
        }

        #endregion

        #region TODO: Implement by block copy logic using class-decorator BufferedStream.

        public static int BufferedCopy(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region TODO: Implement by line copy logic using FileStream and classes text-adapters StreamReader/StreamWriter

        public static int ByLineCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);
            var stringCount = 0;
            using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create))
            {
                using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
                {
                    var line = "";
                    var lineRead = new StreamReader(sourceStream);
                    var lineWrite = new StreamWriter(destinationStream);
                    while ((line = lineRead.ReadLine()) != null)
                    {
                        lineWrite.WriteLine(line);
                        stringCount++;
                    }
                }
            }

            return stringCount;
        }

        #endregion

        #region TODO: Implement content comparison logic of two files 

        public static bool IsContentEquals(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);

            bool flag;
            FileStream file = null;
            FileStream file2 = null;
            using (file = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (file2 = new FileStream(destinationPath, FileMode.OpenOrCreate, FileAccess.Write))
                file.CopyTo(file2);

            if (file.Equals(file2) == false)
                flag = true;
            else
                flag = false;



            return flag;
        }

        #endregion

        #endregion

        #region Private members

        #region TODO: Implement validation logic

        private static void InputValidation(string sourcePath, string destinationPath)
        {
            if (!File.Exists(sourcePath))
                throw new ArgumentException($"File doesn't exist this path {sourcePath}.");
        }

        #endregion

        #endregion

    }
}
