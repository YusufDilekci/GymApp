﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CartManager : ICartService
    {
        private ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }
        public void Add(Cart cart)
        {
            _cartDal.Add(cart);
        }

        public void ClearCartLines(int cartId)
        {
            _cartDal.ClearCartLines(cartId);
        }

        public void Delete(Cart cart)
        {
            _cartDal.Delete(cart);
        }

        public List<Cart> GetAll()
        {
            return _cartDal.GetAll();
        }

        public Cart GetById(int id)
        {
            return _cartDal.Get(i => i.CartId == id);
        }

        public Cart GetByMember(int memberId)
        {
            return _cartDal.Get(i => i.MemberId == memberId);
        }

        public double TotalPrice(int cartId)
        {
            double total = 0;
            var cart = _cartDal.GetWithCartLines(cartId);
            foreach(var cartline in cart.CartLines.ToList())
            {
                total += (cartline.Product.ProductPrice) * (cartline.Quantity);
            }
            return total;
        }

        public void Update(Cart cart)
        {
            _cartDal.Update(cart);
        }
    }
}
