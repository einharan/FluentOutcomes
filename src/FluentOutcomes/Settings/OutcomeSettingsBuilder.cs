using System;
namespace FluentOutcomes.Settings
{
    public class OutcomeSettingsBuilder
    {
        public void AllCorrectMessage(string message)
        {
            if(string.IsNullOrEmpty(message))
            {
                string warning = "Default OK message cannot be null or empty.";
                throw new InvalidOperationException(warning);
            }

            OutcomeSettings.Instance.AllCorrectMessage = message;
        }

        public void DefaultErrorMessage(string message)
        {
            if(string.IsNullOrEmpty(message))
            {
                string warning = "Default error message cannot be null or empty.";
                throw new InvalidOperationException(warning);
            }

            OutcomeSettings.Instance.DefaultErrorMessage = message;
        }

        public void DisablePrefaceMetadata()
        {
            OutcomeSettings.Instance.UsingPrefaceMetadata = false;
        }
    }
}