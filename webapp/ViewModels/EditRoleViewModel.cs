using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Nom du r�le")]
        [Required(ErrorMessage = "Le nom du r�le est requis.")]
        [RegularExpression("^.{1,16}$", ErrorMessage = "Veuillez saisir un maximum de 16 caract�res dans le nom du r�le.")]
        public string RoleName { get; set; }

        [Display(Name = "Utilisateurs associ�s au r�le")]
        public List<string> Users { get; set; }


        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
    }
}
