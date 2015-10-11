using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livro_ProfessionalAsp.NetMVC5_.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Name { get; set; }
        public string Title { get; internal set; }
    }
}