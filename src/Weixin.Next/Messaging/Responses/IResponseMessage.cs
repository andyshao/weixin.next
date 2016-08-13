namespace Weixin.Next.Messaging.Responses
{
    public interface IResponseMessage
    {
        /// <summary>
        /// 转化为返回微信服务器的消息文本
        /// </summary>
        /// <returns></returns>
        string Serialize();
    }

    /// <summary>
    /// 代表需要直接返回字符串, 而不是格式化的 xml 消息
    /// </summary>
    public class RawResponseMessage : IResponseMessage
    {
        private readonly string _message;

        public RawResponseMessage(string message)
        {
            _message = message;
        }

        /// <summary>
        /// 将被直接返回的字符串
        /// </summary>
        public string Message
        {
            get { return _message; }
        }

        public string Serialize()
        {
            return Message;
        }
    }
}