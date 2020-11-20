using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsLINQ
{
    public class LINQExtension
    {
        /// <summary>
        /// Method extracts from file by estimates
        /// </summary>
        /// <param name="stud"></param>
        /// <param name="path"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        public IEnumerable<StudensInformation> ExtractFromTheEvaluationFile(StudentStorage stud, string path, int grade)
        {
            var files = from file in stud.Load(path)
                        where file.Grade > grade
                        select file;
                        

            return files;
        }
        /// <summary>
        /// The method retrieves the specified number of lines
        /// </summary>
        /// <param name="stud"></param>
        /// <param name="path"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public IEnumerable<StudensInformation> TakeRows(StudentStorage stud, string path, int quantity)
        {
            var files = from file in stud.Load(path)
                        select file;
            
            return files.Take(quantity); 
        }
        /// <summary>
        /// The method skips the specified number of lines
        /// </summary>
        /// <param name="stud"></param>
        /// <param name="path"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public IEnumerable<StudensInformation> SkipRows(StudentStorage stud, string path, int quantity)
        {
            var files = from file in stud.Load(path)
                        select file;
            files.Skip(quantity);

            return files.Take(quantity);
        }
        /// <summary>
        /// The method sorts ascending ratings
        /// </summary>
        /// <param name="stud"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<StudensInformation> OrderByAscending(StudentStorage stud, string path)
        {
            var files = from file in stud.Load(path)
                        orderby file.Grade 
                        select file;

            return files;
        }
        /// <summary>
        /// The method sorts descending ratings
        /// </summary>
        /// <param name="stud"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<StudensInformation> OrderByDescending(StudentStorage stud, string path)
        {
            var files = from file in stud.Load(path)
                        orderby file.Grade descending
                        select file;

            return files;
        }

        
    }
}
