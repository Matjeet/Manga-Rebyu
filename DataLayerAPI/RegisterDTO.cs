using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerAPI
{
    public class RegisterDTO
    {
        public string username { get; set; }
        public string idManga { get; set; }
        public int rating { get; set; }
        public string coment { get; set; }
    }
}
