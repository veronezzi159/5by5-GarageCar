using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models
{
    public class ReadFile
    {
        public List<Car> GetData(string path, string file)
        {
            StreamReader reader = new StreamReader(path + file);
            var cars = JsonConvert.DeserializeObject<List<Car>>(reader.ReadToEnd());
            reader.Close();

            return cars;
        }
    }
}
