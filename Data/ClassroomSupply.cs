using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace Classroom_supplies.Model
{
    public class ClassroomSupply
    {
        public int Id { get; set; }

        [Display(Name = "Supply Name")]
        [Required(ErrorMessage = "The supply name is required.")]
        [StringLength(30, ErrorMessage = "The supply name must not exceed 30 characters.")]
        public string Name { get; set; }

        [Display(Name = "SupplyCategory")]
        [Required(ErrorMessage = "The supply SupplyCategory is required.")]
        public SupplyCategory SupplyCategory { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "The quantity is required.")]
        public int Quantity { get; set; }

        [Display(Name = "Unit")]
        [Required(ErrorMessage = "The unit is required.")]
        [StringLength(20, ErrorMessage = "The unit must not exceed 20 characters.")]
        public string Unit { get; set; }

        [Display(Name = "Unit Price")]
        [Required(ErrorMessage = "The unit price is required.")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "The supplier name is required.")]
        [StringLength(30, ErrorMessage = "The supplier name must not exceed 30 characters.")]
        public string Supplier { get; set; }

        [Display(Name = "Purchase Date")]
        [Required(ErrorMessage = "The purchase date is required.")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "The location is required.")]
        [StringLength(50, ErrorMessage = "The location must not exceed 50 characters.")]
        public string Location { get; set; }
    }

    public enum SupplyCategory
    {
        Art,
        Science,
        Music,
        Cleaning
    }
}
