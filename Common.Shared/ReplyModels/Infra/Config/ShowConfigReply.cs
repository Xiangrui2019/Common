namespace Common.Shared.Responsers.Infra.Config
{
    public class ShowConfigReply : CommonReply
    {
        public ConfigDto Data { get; set; }
    }

    public class ConfigDto
    {
        public int Id { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
    }
}