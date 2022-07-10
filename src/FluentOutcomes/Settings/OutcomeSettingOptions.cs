using System;

namespace FluentOutcomes.Settings
{
    public class OutcomeSettingOptions
    {
        internal OutcomeSettingOptions()
        {

        }

        public void SetAllCorrectMessage(string message)
        {
            if(string.IsNullOrEmpty(message))
            {
                string warning = "Default OK message cannot be null or empty.";
                throw new InvalidOperationException(warning);
            }

            OutcomeSettings.Instance.AllCorrectMessage = message;
        }

        public void SetDefaultErrorMessage(string message)
        {
            if(string.IsNullOrEmpty(message))
            {
                string warning = "Default error message cannot be null or empty.";
                throw new InvalidOperationException(warning);
            }

            OutcomeSettings.Instance.DefaultErrorMessage = message;
        }

        public void Metadata(Action<MetadataSettingOptions> options)
        {
            MetadataSettingOptions settings = new MetadataSettingOptions();
            options?.Invoke(settings);
        }
    }
}