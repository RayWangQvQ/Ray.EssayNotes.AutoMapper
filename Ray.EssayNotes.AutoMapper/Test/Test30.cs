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
    [Description("映射时的覆盖")]
    public class Test30 : ITest
    {
        public void Run()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Test11).Assembly));
            IMapper mapper = config.CreateMapper();

            UserEntity entity = new UserEntity("测试覆盖", "123", 25);
            PrintEntity(entity);

            UserDto dto = new UserDto
            {
                Id = 1,//entity没有
                Name = "newName"
            };

            mapper.Map(dto, entity);
            PrintEntity(entity);


            void PrintEntity(UserEntity entity)
            {
                Console.WriteLine($"HashCode：{entity.GetHashCode()}");
                Console.WriteLine(entity.AsFormatJsonStr());
            }

            /*
             * 对于已存在的Destination对象，映射时是全部覆盖，
             * Source为null则覆盖为Null
             * 不会保留原Destination对象的值
             * 单Destination的引用地址不会变（即非深拷贝）
             */
        }

        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<UserDto, UserEntity>();
            }
        }
    }
}
