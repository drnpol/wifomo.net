﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.DataAnnotations;

namespace WIF.Base.Mvc.Models.ManageViewModels
{
    public class VerifyPhoneNumberViewModel
    {
        [Required]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}