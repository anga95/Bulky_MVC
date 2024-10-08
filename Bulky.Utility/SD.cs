﻿namespace Bulky.Utility
{
    public static class SD
    {
        public const string Role_Customer = "Customer";
        public const string Role_Company = "Company";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";

        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "InProcess";
        public const string StatusShipped = "Shipped";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayedPayment = "ApprovedForDelayedPayment";
        public const string PaymentStatusRejected = "Rejected";

        // Filtreringsstatusar (för URL och JavaScript)
        public const string FilterPending = "pending";
        public const string FilterInProcess = "inprocess";
        public const string FilterCompleted = "completed";
        public const string FilterApproved = "approved";
        public const string FilterAll = "all";

        public const string SessionCart = "SessionShoppingCart";
    }

}
