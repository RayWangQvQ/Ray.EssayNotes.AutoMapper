using System;
using System.Collections.Generic;
using System.Text;

namespace Ray.EssayNotes.AutoMapper.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity(string name, string pwd, int age)
        {
            Name = name;
            Pwd = pwd;
            Age = age;
        }

        public string Name { get; set; }

        public string Pwd { get; set; }

        public int Age { get; set; }
    }
}
