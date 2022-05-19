using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ListUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<user> list = new List<user>();
            user user1 = new user(1, "Nguyễn Thế Duyệt");
            user user2 = new user(2, "Nguyễn Văn An");
            user user3 = new user(3, "Lê Kim Phi");
            user user4 = new user(4, "Bùi Đào Quốc Huy");
            list.Add(user4);
            list.Add(user3);
            list.Add(user2);
            list.Add(user1);
            foreach(var item in list)
            {
                Console.WriteLine(item.fixNameUser());
            }
            
        }
    }
}
