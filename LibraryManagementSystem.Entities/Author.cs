using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }    
        public string Surname {  get; set; }
        public int Age {  get; set; }
        public string ShortDesc {  get; set; }
        public string AuthorImageBase64 {  get; set; }
        public List<Book> Books { get; set; }
    }
}
