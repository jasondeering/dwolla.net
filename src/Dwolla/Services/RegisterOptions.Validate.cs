using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dwolla.Services
{
    public partial class RegisterOptions
    {
        private const int MIN_PASSWORD_LENGTH = 8;
        private const int MAX_PASSWORD_LENGTH = 15;

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < MIN_PASSWORD_LENGTH || password.Length > MAX_PASSWORD_LENGTH) return false;

            var hasUpperCase = password.Any(c => char.IsUpper(c));
            var hasLowerCase = password.Any(c => char.IsLower(c));
            var hasDigit = password.Any(c => char.IsDigit(c));

            return hasUpperCase && hasLowerCase && hasDigit;
        }

        public bool PasswordIsValid()
        {
            return IsValidPassword(this.Password);
        }

        public static bool IsValidPin(string pin)
        {
            return Regex.IsMatch(pin, "^[0-9]{4}$");
        }

        public bool PinIsValid()
        {
            return IsValidPin(this.Pin);
        }
    }
}
