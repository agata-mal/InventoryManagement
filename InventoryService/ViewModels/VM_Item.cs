﻿using FluentValidation.Attributes;
using InventoryService.Enums;
using InventoryService.Validation;
using System.ComponentModel.DataAnnotations;

namespace InventoryService.ViewModels
{
   
    public class VM_Item
    {
        public int Id { get; set; }
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public Unit Unit { get; set; }
        public double ExpectedAmount { get; set; }
        public double? RealAmount { get; set; }
    }
}