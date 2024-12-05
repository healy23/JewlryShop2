﻿namespace JewlryShop2.Models
{
    public class Jewelry
    {
        public int JewelryID { get; set; }
        public string JewelryName { get; set; }

        public int Price { get; set; }
        public string Material { get; set; }

        //public int CostumerID { get; set; }
        //public Costumer CostumerI{ get; set; }


        public ICollection<Review> Reviews { get; set; }

    }
}
