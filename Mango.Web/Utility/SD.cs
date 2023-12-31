﻿namespace Mango.Web.Utility
{
    public class SD // static details
    {
        public static string CouponAPIBase { get; set; }
        public static string ProductAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public static string ShoppingCartAPIBase { get; set; }
        public static string OrderAPIBase { get; set; }
        public static string RoleAdmin = "ADMIN";
        public static string RoleCustomer = "CUSTOMER";
        public static string TokenCookie = "JWTToken";
        public enum ApiType
        { 
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
