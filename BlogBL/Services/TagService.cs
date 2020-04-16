using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Entities;
using BlogDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class TagService : GenericService<TagBL, Tag>, ITagService
    {
        private IMapper _mapper;

        public TagService(IGenericRepository<Tag> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override TagBL Map(Tag entity)
        {
            return _mapper.Map<TagBL>(entity);
        }

        public override Tag Map(TagBL blmodel)
        {
            return _mapper.Map<Tag>(blmodel);
        }

        public override IEnumerable<TagBL> Map(IList<Tag> entities)
        {
            return _mapper.Map<IEnumerable<TagBL>>(entities);
        }

        public override IEnumerable<Tag> Map(IList<TagBL> models)
        {
            return _mapper.Map<IEnumerable<Tag>>(models);
        }

    }
}
