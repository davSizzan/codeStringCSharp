using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ListUsers
{
    class user
    {
        int id;
        string name;
        public user(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string fixNameUser()
        {
            String n = RemoveVietnameseTone(name)+"_";
           string[] listStr = n.Split(' ');
            n = listStr[listStr.Length - 1];
            for(int i =0;i< listStr.Length - 1; i++)
            {
                n+=  listStr[i].Remove(1);
         
            }
            return n;
        }
        public static string RemoveVietnameseTone(string text)
        {
            string result = text;
            result = Regex.Replace(result, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ|/g", "a");
            result = Regex.Replace(result, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ|/g", "e");
            result = Regex.Replace(result, "ì|í|ị|ỉ|ĩ|/g", "i");
            result = Regex.Replace(result, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ|/g", "o");
            result = Regex.Replace(result, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ|/g", "u");
            result = Regex.Replace(result, "ỳ|ý|ỵ|ỷ|ỹ|/g", "y");
            result = Regex.Replace(result, "đ", "d");
            return result;
        }
    }
}
