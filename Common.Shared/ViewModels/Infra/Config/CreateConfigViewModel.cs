using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Common.Shared.ViewModels.Infra.Config
{
    public class CreateConfigViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(35)]
        public string ConfigName { get; set; }
        [Required]
        [MinLength(10)]
        public string ConfigValue { get; set; }
    }
}