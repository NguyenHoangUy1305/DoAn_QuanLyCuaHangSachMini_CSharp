namespace QuanLyCuaHangSachMini.Helpers
{
    public static class PasswordHelper
    {
        public static bool IsHashedPassword(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return value.StartsWith("$2a$") ||
                   value.StartsWith("$2b$") ||
                   value.StartsWith("$2y$");
        }

        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        public static bool VerifyPassword(string plainPassword, string? storedPassword)
        {
            if (string.IsNullOrWhiteSpace(storedPassword))
                return false;

            if (IsHashedPassword(storedPassword))
            {
                try
                {
                    return BCrypt.Net.BCrypt.Verify(plainPassword, storedPassword);
                }
                catch
                {
                    return false;
                }
            }

            // Ho tro du lieu cu luu mat khau dang text.
            return plainPassword == storedPassword;
        }

        public static bool ShouldUpgradeLegacyPassword(string? storedPassword)
        {
            return !string.IsNullOrWhiteSpace(storedPassword) && !IsHashedPassword(storedPassword);
        }
    }
}
