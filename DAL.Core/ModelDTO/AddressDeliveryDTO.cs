﻿namespace DAL.Core.ModelDTO
{
    public class AddressDeliveryDTO
    {

        public int Id { get; set; }
        public dynamic City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
    }
}