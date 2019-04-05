using System;
using System.Collections.Generic;

namespace ModuleFun.Models
{
    public class User
    {
        public string Firstname{get;set;}
        public string Lastname{ get; set; }
    } 

    public class Users
    {
        public List<User> UserList{get;set;} = new List<User>();
    }  
}