using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIChallenge.Models
{
    public class RickAndMorty
    {
        [JsonProperty("characters")]
        public List<string> Characters { get; set; }

        [JsonProperty("locations")]
        public List<string> Locations { get; set; }

        [JsonProperty("episodes")]
        public List<string> Episodes { get; set; }
    }
}
