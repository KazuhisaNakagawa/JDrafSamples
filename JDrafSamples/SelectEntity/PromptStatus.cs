namespace SelectEntity
{
    public enum PromptStatus
    {
        None = 5000,
        Modeless = 5027,
        Normal = 5100,
        Error = -5001,
        Cancel = -5002,
        Rejected = -5003,
        Failed = -5004,
        Keyword = -5005,
        Direct = -5999
    }
}