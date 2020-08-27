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
    [Description("Profile + 扫描程序集")]
    public class Test11 : ITest
    {
        public void Run()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Test11).Assembly));
            IMapper mapper = config.CreateMapper();

            UserEntity userEntity = new UserEntity("测试", "123", 25);

            UserDto dto = mapper.Map<UserEntity, UserDto>(userEntity);

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
