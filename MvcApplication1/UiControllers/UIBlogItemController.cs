using DonnBusiness.BusinessLogic.Interface;
using DonnWeb.Models.Blog;
using DonnWeb.UIMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UiControllers
{
    public class UIBlogItemController
    {
        private readonly IBlogLogic _logic;
        private readonly IBlogItemMapper _mapper;

        public UIBlogItemController(IBlogLogic logic, IBlogItemMapper mapper)
        {
            _logic = logic;
            _mapper = mapper;
        }

        public BlogItem GetBlogModelByUri(String uri)
        {
          return _mapper.Map(_logic.GetBlogByUri(uri));         
        }

        public IEnumerable<BlogItem> GetBlogItems()
        {
            return _logic.GetAllBlogItems().Select(x => _mapper.Map(x));
        }

    }
}