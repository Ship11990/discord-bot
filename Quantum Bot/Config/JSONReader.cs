using DSharpPlus.Net.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bot.Config
{
    internal class JSONReader
    {
        public string token {  get; set; }
        public string perfix { get; set; }

        public async Task ReadJSON()
        {
            using (StreamReader sr  = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONStructure data = JsonConvert.DeserializeObject<JSONStructure>(json);

                this.token = data.token;
                this.perfix = data.perfix;
            }
        }
    }

    internal sealed class JSONStructure
    {
        public string token { get; set; }
        public string perfix { get; set; }

    }
}
