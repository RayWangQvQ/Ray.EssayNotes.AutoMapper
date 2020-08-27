using System;
using System.Collections.Generic;
using System.Text;

namespace Ray.EssayNotes.AutoMapper.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public DateTime CreateTime { get; set; }
        public long Creator { get; set; }

        public DateTime? UpdateTime { get; set; }
        public long? Updater { get; set; }
    }
}
