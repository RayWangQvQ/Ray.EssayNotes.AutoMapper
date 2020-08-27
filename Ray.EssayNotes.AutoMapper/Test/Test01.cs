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
    [Description("基础用法：通过MapperConfiguration创建IMapper")]
    public class Test01 : ITest
    {
        public void Run()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserEntity, UserDto>());
            IMapper mapper = config.CreateMapper();

            UserEntity userEntity = new UserEntity("测试", "123", 25);

            UserDto dto = mapper.Map<UserDto>(userEntity);

            Console.WriteLine(dto.AsFormatJsonStr());
        }
    }
}
