using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public string  Image { get; set; }
        public string  Client { get; set; }
        public string  Url { get; set; }
        public Project(long id, string name, string description, string client,string image,string url)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
            Url = url;
        }
    }
}
