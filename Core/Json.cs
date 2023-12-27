using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Wpf_13._1.Core
{
    public class Json
    {
        public string Data1 { get; set; }
        public int Data2 { get; set; }
    }

    public class AppDataService
    {
        private readonly string _filePath;

        public AppDataService(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(Json data)
        {
            var json = JsonSerializer.Serialize(data);
            File.WriteAllText(_filePath, json);
        }

        public Json Load()
        {
            if (!File.Exists(_filePath))
            {
                return null;
            }

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<Json>(json);
        }
    }
}