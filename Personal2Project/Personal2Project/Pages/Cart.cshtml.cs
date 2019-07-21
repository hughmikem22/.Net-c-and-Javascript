using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CartInASPNETCoreRazorPages.Pages;
using Personal2Project.Data;

namespace CartInASPNETCoreRazorPages.Pages
{
    public class CartModel : PageModel
    {
        public List<Item> cart;
        public void OnGet()
        {
         }
        public void OnGetBuyNow(string id)
        {
            var productModel = new ProductModel();
             
            if (cart == null)
            {
                 cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = productModel.find(id),
                    Quantity = 1
                });
                
             }
            else
            {
                int index = Exists(cart, id);
                if (index == 1)
                {
                    cart.Add(new Item
                    {
                        Product = productModel.find(id),
                        Quantity = +1
                    });

                }
                else
                {
                    cart[index].Quantity++;
                }
                 }
            
        }

        public void OnGetDelete(string id)
        {
            
            int index = Exists(cart, id);
            cart.RemoveAt(index);
        }
        private int Exists(List<Item> cart, string id)
        {
            for(var i = 0; i <cart.Count; i++)
            {
                if(cart[i].Product.Id == id)
                {
                    return i;
                }
                
            }
            return -1;
        }   
    }


}
           