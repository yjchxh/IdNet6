using System.Threading.Tasks;

namespace IdNet6.Validation
{
    /// <summary>
    /// No-op client configuration validator (for backwards-compatibility).
    /// </summary>
    /// <seealso cref="IdNet6.Validation.IClientConfigurationValidator" />
    public class NopClientConfigurationValidator : IClientConfigurationValidator
    {
        /// <summary>
        /// Determines whether the configuration of a client is valid.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public Task ValidateAsync(ClientConfigurationValidationContext context)
        {
            context.IsValid = true;
            return Task.CompletedTask;
        }
    }
}