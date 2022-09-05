using Microsoft.IdentityModel.Tokens;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Windows.Forms;

namespace JwtHelper.TokenService
{
    /// <summary>
    /// Generate JWT Service
    /// </summary>
    public static class JwtTokenService
    {
        /// <summary>
        /// Default jwt key
        /// </summary>
        private const string defaultKey = "";

        /// <summary>
        /// Parse token even its expired
        /// </summary>
        /// <param name="token">string encoded jwt token</param>
        /// <returns>List of claims in Jwt token if its valid</returns>
        public static TokenIdentity GetPrincipalFromExpiredToken(string token, bool isDefaultKey, string key)
        {
            if (string.IsNullOrWhiteSpace(token) || string.IsNullOrWhiteSpace(token.Replace("Bearer ", string.Empty).Trim()))
            {
                MessageBox.Show("Base64 token cannot be empty or white space!", "Convert failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default;
            }

            if (!isDefaultKey && string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Key cannot be empty or white space!", "Convert failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default;
            }

            if (isDefaultKey && string.IsNullOrWhiteSpace(defaultKey))
            {
                MessageBox.Show("Key default cannot be empty or white space!", "Convert failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default;
            }

            token = token.Replace("Bearer ", string.Empty).Trim();
            var symmetricSecurityKey = Encoding.UTF8.GetBytes(isDefaultKey ? defaultKey : key);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = true,
                ValidIssuer = "http://localhost",
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(symmetricSecurityKey),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);

                var jwtSecurityToken = securityToken as JwtSecurityToken;


                if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Token is not valid!", "Convert failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return default;
                }

                var result = new TokenIdentity(principal);
                result.JsonContent = jwtSecurityToken.Payload.SerializeToJson();

                // Check Validation Options : Token shouldn't be too old
                if (DateTime.UtcNow < jwtSecurityToken.ValidTo && DateTime.UtcNow > jwtSecurityToken.ValidFrom)
                {
                    result.IsValid = true;
                }

                result.IssueAt = jwtSecurityToken.IssuedAt.ToLocalTime();
                result.NotBefore = jwtSecurityToken.ValidFrom.ToLocalTime();
                result.ExpireAt = jwtSecurityToken.ValidTo.ToLocalTime();
                result.Issuer = jwtSecurityToken.Issuer;

                return result;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is SecurityTokenDecryptionFailedException || ex is SecurityTokenException)
            {
                MessageBox.Show("Token is not valid!", "Convert failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error Type: {ex.GetType()}\n\rError message: {ex.Message}", "Unknow error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }
    }
}
