using System;
using System.Security.Cryptography;

public static class PasswordHelper
{
    private const int SaltSize = 16; // 128-bit salt
    private const int HashSize = 20; // 160-bit hash
    private const int IterationCount = 10000; // Number of iterations for PBKDF2

    /// <summary>
    /// Hashes a password with a newly generated salt.
    /// </summary>
    /// <param name="password">The password to hash.</param>
    /// <param name="salt">The generated salt.</param>
    /// <returns>The hashed password as a Base64 string.</returns>
    public static string HashPassword(string password, out byte[] salt)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password cannot be null or empty.", nameof(password));

        // Generate a random salt
        using (var rng = new RNGCryptoServiceProvider())
        {
            salt = new byte[SaltSize];
            rng.GetBytes(salt);
        }

        // Use PBKDF2 to hash the password
        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, IterationCount))
        {
            byte[] hash = pbkdf2.GetBytes(HashSize);
            byte[] hashBytes = new byte[SaltSize + HashSize];

            // Combine salt and hash
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            return Convert.ToBase64String(hashBytes); // Return as Base64 string
        }
    }

    /// <summary>
    /// Hashes a password using an existing salt for verification.
    /// </summary>
    /// <param name="password">The password to verify.</param>
    /// <param name="salt">The existing salt.</param>
    /// <returns>The hashed password as a Base64 string.</returns>
    public static string HashPasswordWithSalt(string password, byte[] salt)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password cannot be null or empty.", nameof(password));

        if (salt == null || salt.Length != SaltSize)
            throw new ArgumentException($"Salt must be {SaltSize} bytes long.", nameof(salt));

        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, IterationCount))
        {
            byte[] hash = pbkdf2.GetBytes(HashSize);
            byte[] hashBytes = new byte[SaltSize + HashSize];

            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            return Convert.ToBase64String(hashBytes); // Return as Base64 string
        }
    }

    public static bool VerifyHashedPassword(string inputPassword, string storedHashedPassword, byte[] storedSalt)
    {
        // Hash the input password with the stored salt using HashPasswordWithSalt
        string hashedInputPassword = HashPasswordWithSalt(inputPassword, storedSalt);

        // Compare the hashed input password with the stored hashed password
        return hashedInputPassword == storedHashedPassword;
    }
}