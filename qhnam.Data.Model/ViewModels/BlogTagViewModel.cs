using System;
using System.Collections.Generic;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class BlogTagViewModel
    {
        public int BlogId { set; get; }

        public string TagId { set; get; }

        public virtual BlogViewModel Blog { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}
