﻿using EPiServer.Commerce.Order;

namespace EPiServer.Reference.Commerce.Site.B2B.Models.ViewModels
{
    public class OrderOrganizationViewModel
    {
        public string OrderNumber { get; set; }
        public OrderReference OrderLink { get; set; }
        public string SubOrganization { get; set; }
        public string User { get; set; }
        public string Status { get; set; }
        public string Ammount { get; set; }
        public string PlacedOrderDate { get; set; }
        public string Currency { get; set; }
    }
}