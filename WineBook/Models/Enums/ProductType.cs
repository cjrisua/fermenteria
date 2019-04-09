using System;
using System.ComponentModel.DataAnnotations;
namespace WineBook.Models.Enums
{
    public enum YesNo
    {
        Yes =1,
        No = 0,
        Unknown = 100
    };
    public enum ProductionType
    {
        [Display(Name ="Wine Producer")]
        Wine = 1,
        [Display(Name ="Brew Producer")]
        Brewer = 2,
        [Display(Name ="Other")]
        Other = 100
    };
}
