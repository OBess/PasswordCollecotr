using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PasswordCollector.Systems
{
    class FileSystem
    {
        public readonly static string FolderPath = "data";
        public static void DirectoryIsExist(string path)
        {
            if (path == "") return;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        public static void BinarySerialize(object data, string path)
        {
            if (data == null) return;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path)) File.Delete(path);
            fileStream = File.Create(path);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public static object BinaryDeserialize(string path)
        {
            object obj = null;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path))
            {
                try
                {
                    using (FileStream fileStream = File.OpenRead(path))
                    {
                        if (fileStream.Length != 0) obj = bf.Deserialize(fileStream);
                    }
                }
                catch (Exception e) { }
            }
            return obj;
        }
    }
}
