using System;
using System.Collections.Generic;
using System.Text;

namespace Ray.EssayNotes.AutoMapper.Dtos
{
    public class UserDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Pwd { get; set; }

        public int Age { get; set; }
    }
}
