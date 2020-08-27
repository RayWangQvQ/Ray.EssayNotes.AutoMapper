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
    [Description("集合")]
    public class Test20 : ITest
    {
        public void Run()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Test11).Assembly));
            IMapper mapper = config.CreateMapper();

            List<UserEntity> userEntityList = new List<UserEntity>
            {
                new UserEntity("测试1", "123", 25),
                new UserEntity("测试2", "123", 25),
            };

            List<UserDto> dto = mapper.Map<List<UserEntity>, List<UserDto>>(userEntityList);

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
