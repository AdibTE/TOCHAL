using System;
using System.Collections.Generic;
using System.Text;

namespace Tochal.Core.DomainModels.Entity.Content
{
    public class Gallery
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        public string Alt { get; set; }

        public string Image { get; set; }

    }

    

}
