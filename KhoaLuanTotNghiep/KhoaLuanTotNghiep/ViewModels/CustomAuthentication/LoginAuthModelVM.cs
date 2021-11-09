using System.ComponentModel.DataAnnotations;

namespace KhoaLuanTotNghiep_BackEnd.ViewModel.CustomAuthentication
{
    public class LoginAuthModelVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}   