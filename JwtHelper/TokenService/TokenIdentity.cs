using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace JwtHelper.TokenService
{
    /// <summary>
    /// Get Identity Service
    /// </summary>
    public class TokenIdentity
    {
        private const string BranchIdClaim = "BranchId";
        private const string BranchNameClaim = "BranchName";
        private const string PositionClaim = "Position";
        private const string UserFullNameClaim = "FullName";
        private const string AccountingIdClaim = "AccountingId";
        private const string AdminInAppClaim = "AdminInApp";

        private readonly ClaimsPrincipal principal;

        public TokenIdentity(ClaimsPrincipal principal)
        {
            this.principal = principal ?? new ClaimsPrincipal();
        }

        public bool IsAuthenticated => principal?.Identity?.IsAuthenticated ?? false;

        public int UserId => GetPropertyFromIdentity<int>(ClaimTypes.NameIdentifier);

        public string Username => principal?.Identity?.Name ?? "None";

        public int BranchId => GetPropertyFromIdentity<int>(BranchIdClaim);

        public string BranchName => GetPropertyFromIdentity<string>(BranchNameClaim);

        public string Position => GetPropertyFromIdentity<string>(PositionClaim);

        public string UserFullName => GetPropertyFromIdentity<string>(UserFullNameClaim);

        public short? AccountingId => GetPropertyFromIdentity<short?>(AccountingIdClaim);

        public IEnumerable<string> Audience => GetAudiencesFromIdentity();

        public IEnumerable<string> Roles => GetRolesFromIdentity();

        public IEnumerable<string> AdminInApp => GetAppWithAdminRoleFromIdentity();

        public bool IsValid { get; set; }
        public string JsonContent { get; set; }
        public DateTime IssueAt { get; set; }
        public DateTime NotBefore { get; set; }
        public DateTime ExpireAt { get; set; }
        public string Issuer { get; set; }

        /// <summary>
        /// Get Property from Claims
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="claimType"></param>
        /// <returns></returns>
        private T GetPropertyFromIdentity<T>(string claimType)
        {
            if (principal?.Identity is ClaimsIdentity identity)
            {
                var property = identity.Claims?.FirstOrDefault(x => x.Type == claimType)?.Value;
                if (property != null)
                {
                    return ChangeType<T>(property);
                }
            }

            return default;
        }

        /// <summary>
        /// Generic Change type for nullable type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        private static T ChangeType<T>(object value)
        {
            var t = typeof(T);

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return default(T);
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return (T)Convert.ChangeType(value, t);
        }

        /// <summary>
        /// Get Roles
        /// </summary>
        /// <returns></returns>
        private IEnumerable<string> GetRolesFromIdentity()
        {
            if (principal?.Identity is ClaimsIdentity identity)
            {
                var roles = identity.Claims?.Where(x => x.Type == ClaimTypes.Role).Select(y => y.Value);
                return roles;
            }

            return new HashSet<string>();
        }

        /// <summary>
        /// Get Applications (Audiences)
        /// </summary>
        /// <returns></returns>
        private IEnumerable<string> GetAudiencesFromIdentity()
        {
            if (principal?.Identity is ClaimsIdentity identity)
            {
                var audienceString = identity.Claims?.FirstOrDefault(x => x.Type == "aud")?.Value;
                var audience = !string.IsNullOrWhiteSpace(audienceString)
                    ? audienceString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    : new[] { "*" };

                return audience;
            }

            return new HashSet<string>();
        }

        /// <summary>
        /// Get Application that has admin role
        /// </summary>
        /// <returns></returns>
        private IEnumerable<string> GetAppWithAdminRoleFromIdentity()
        {
            if (principal?.Identity is ClaimsIdentity identity)
            {
                var apps = identity.Claims?.Where(x => x.Type == AdminInAppClaim).Select(y => y.Value);
                return apps;
            }

            return new HashSet<string>();
        }
    }

}
