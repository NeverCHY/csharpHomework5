using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using p01;

namespace p02
{
    class pro : stu
    {
        static string projPath = Environment.CurrentDirectory;
        static void DeSerializerJSON()
        {
            FileStream fs = new FileStream($@"{projPath}\stu.json",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
            String jsondata = sr.ReadToEnd();
            List<stu> stu_list = new List<stu>();
            stu_list = (List<stu>)JsonSerializer.Deserialize(jsondata,
                typeof(List<stu>));
            foreach (var stu in stu_list)
            {
                stu.pIn();
            }
        }
        static void Main(string[] args)
        {
            List<stu> slist = new stu().stulist();
            FileStream fs = new FileStream($@"{projPath}\stu.json", FileMode.Create);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            Utf8JsonWriter jw = new Utf8JsonWriter(fs);
            JsonSerializer.Serialize(jw, stu_list, options);
            fs.Close();
            DeSerializerJSON();
        }
    }
}
