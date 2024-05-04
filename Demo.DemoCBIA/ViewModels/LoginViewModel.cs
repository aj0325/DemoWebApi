using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Demo.DemoCBIA.ViewModels
{
    public class LoginViewModel : BaseLoginViewModel
    {
        bool passEntered = false;
        bool isLoginEnabled = false;
        string login = "";
        bool loginHasError = false;
        string password = "";
        bool passwordHasError = false;

        public LoginViewModel()
        {
            
        }

        public bool IsLoginEnabled
        {
            get { return this.isLoginEnabled; }
            set { SetProperty(ref this.isLoginEnabled, value); }
        }

        public string Login
        {
            get { return this.login; }
            set { SetProperty(ref this.login, value); }
        }

        public bool LoginHasError
        {
            get { return this.loginHasError; }
            set { SetProperty(ref this.loginHasError, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetProperty(ref this.password, value); }
        }

        public bool PasswordHasError
        {
            get { return this.passwordHasError; }
            set { SetProperty(ref this.passwordHasError, value); }
        }

        public ICommand SignUpCommand { private set; get; }

        public bool ValidateEditors()
        {
            if (Password.Length < 6)
            {
                IsLoginEnabled = false;
            }
            if (Password.Length > 5)
            {
                this.passEntered = true;
            }
            if (!this.passEntered)
            {
                return true;
            }
            PasswordHasError = !Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$");
            LoginHasError = String.IsNullOrEmpty(Login);
            if (!PasswordHasError && !LoginHasError)
            {
                IsLoginEnabled = true;
                return true;
            }
            else
            {
                IsLoginEnabled = false;
                return false;
            }
        }
    }
}
