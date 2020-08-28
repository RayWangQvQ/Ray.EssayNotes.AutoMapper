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
    [Description("自定义映射规则")]
    public class Test90 : ITest
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
                CreateMap<UserEntity, UserDto>()
                    .ForMember("Name", opt => opt.MapFrom(src => src.Pwd))
                    .ForMember(dest => dest.Pwd, opt => opt.MapFrom(src => src.Name));
            }
        }
    }
}
