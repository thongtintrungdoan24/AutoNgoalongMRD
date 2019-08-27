﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoNgoalongMRD
{
    public static class classSerializeData
    {
        public enum Formatter { Binary, Xml }

        #region Serialization methods
        public static void Serialize2File<T>(T obj, string pathSpec,
            Formatter formatter)
        {
            try
            {
                switch (formatter)
                {
                    case (Formatter.Binary):
                        using (var fs = new FileStream(pathSpec, FileMode.OpenOrCreate,
                                            FileAccess.Write, FileShare.None))
                            (new BinaryFormatter()).Serialize(fs, obj);
                        break;

                    case (Formatter.Xml):
                        var serializer = new XmlSerializer(typeof(T));
                        TextWriter textWriter = new StreamWriter(pathSpec);
                        serializer.Serialize(textWriter, obj);
                        textWriter.Close();
                        break;

                    default:
                        throw new MyCustomException("Invalid Formatter option");
                }
            }
            catch (SerializationException sX)
            {
                var errMsg = String.Format(
                    "Unable to serialize {0} into file {1}",
                    obj, pathSpec);
                throw new MyCustomException(errMsg, sX);
            }
        }
        public static T DeSerializeFromFile<T>(string pathSpec,
            Formatter formatter) where T : class
        {
            try
            {
                switch (formatter)
                {
                    case (Formatter.Binary):
                        using (var strm = new FileStream(pathSpec,
                                            FileMode.Open, FileAccess.Read, FileShare.None))
                        {
                            IFormatter fmt = new BinaryFormatter();
                            var o = fmt.Deserialize(strm);
                            strm.Close();
                            if (!(o is T))
                                throw new ArgumentException("Bad Data File");
                            return o as T;
                        }

                    case (Formatter.Xml):
                        var serializer = new XmlSerializer(typeof(T));
                        TextReader rdr = new StreamReader(pathSpec);
                        T ret = (T)serializer.Deserialize(rdr);
                        rdr.Close();
                        return ret;

                    default:
                        throw new MyCustomException("Invalid Formatter option");
                }
            }
            catch (SerializationException sX)
            {
                var errMsg = String.Format(
                    "Unable to deserialize {0} from file {1}",
                    typeof(T), pathSpec);
                throw new MyCustomException(errMsg, sX);
            }
        }
        #endregion Serialization methods
        
    }

    [Serializable]
    internal class MyCustomException : Exception
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string message) : base(message)
        {
        }

        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }


        protected MyCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
