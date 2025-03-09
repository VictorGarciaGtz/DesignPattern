using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public class Generator
    {
        public List<string> Content { get; set; }
        public string Path { get; set; }
        public TypeFormat Format { get; set; }
        public TypeChracater Character { get; set; }

        public void Save()
        {
            string result = "";
            result = Format switch
            {
                TypeFormat.Json => GetJson(),
                TypeFormat.Pipes => GetPipes(),
                _ => result
            };

            if (Character == TypeChracater.Uppercase)
            {
                result = result.ToUpper();
            }
            else if (Character == TypeChracater.Lowercase)
            {
                result = result.ToLower();
            }

            File.WriteAllText(Path, result);

        }

        private string GetJson() => JsonSerializer.Serialize(Content);

        private string GetPipes() => Content.Aggregate((x, y) => $"{x}|{y}");
    }
}
