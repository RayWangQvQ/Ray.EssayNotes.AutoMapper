using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using AutoMapper;
using Ray.EssayNotes.AutoMapper.Dtos;
using Ray.EssayNotes.AutoMapper.Entities;
using Ray.Infrastructure.EssayTest;

namespace Ray.EssayNotes.AutoMapper.Test
{
    [Description("利用Profile")]
    public class Test10 : ITest
    {
        public void Run()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<UserProfile>());
            IMapper mapper = config.CreateMapper();

            UserEntity userEntity = new UserEntity("测试", "123", 25);

            UserDto dto = mapper.Map<UserDto>(userEntity);

            Console.WriteLine(dto.AsFormatJsonStr());
        }

        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<UserEntity, UserDto>();
            }
        }
    }
}
