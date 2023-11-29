using System;
using System.Collections.Generic;
using System.Text;

namespace FunShopMVVMTwo.DTO
{
    internal class DTOProduct
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

        public int IdCategory { get; set; }
    }
}
