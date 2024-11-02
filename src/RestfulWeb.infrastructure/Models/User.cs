﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RestfulWeb.infrastructure.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserTel { get; set; }
        public string UserTelExtension { get; set; }
        public string UserPhone { get; set; }
        public int? RoleId { get; set; }
        public string UserPermission { get; set; }
        public int ErrorPasswordCount { get; set; }
        public DateTime? LastChangePasswordDatetime { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string CreateUserName { get; set; }
        public string UpdateUserName { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public bool IsEnabled { get; set; }
    }
}