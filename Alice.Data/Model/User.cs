using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
