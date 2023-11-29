using FunShopMVVMTwo.DTO;
using FunShopMVVMTwo.Tools;
using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunShopMVVMTwo.FunClasses
{
    internal static class ProductFun
    {
        public static Task AddProducrt(DTOProduct product)
        {
            return Task.CompletedTask;
        }

        public static Task Delete(DTOProduct product) 
        {
            return  FunClient.instance.DeleteAsync($"Books/{product.Id}");
        }

        public static Task UpdateBook(DTOProduct product)
        {
            return Task.CompletedTask;
        }

       
    
    }
}
