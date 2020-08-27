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
    [Description("集合为null的情况")]
    public class Test21 : ITest
    {
        public void Run()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Test11).Assembly));
            IMapper mapper = config.CreateMapper();

            List<UserEntity> userEntityList = null;

            List<UserDto> dto = mapper.Map<List<UserEntity>, List<UserDto>>(userEntityList);

            Console.WriteLine(dto.AsFormatJsonStr());

            /*
             * 映射集合时，如果源值为 null，则 AutoMapper 会将目标字段映射为空集合，而不是 null。
             * 这与 Entity Framework 和 Framework Design Guidelines 的行为一致，
             * 认为 C＃ 的数组、List、Collection、Dictionary 和 IEnumerable 永远都不应该为 null。
             */
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
