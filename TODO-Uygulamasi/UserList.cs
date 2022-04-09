using System.Collections.Generic;

namespace Todo
{
    public class UserList
    {
        public List<User> all = new List<User>();

        public UserList()
        {
            all.Add(new User(1, "Hava Karagöz"));
            all.Add(new User(2, "Elif Karagöz"));
          
        }
    }
}