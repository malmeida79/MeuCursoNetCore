namespace Curso.Domain.Containers
{
    public class MessageModel
    {
        public MessageModel()
        {

        }
        public MessageModel(string message)
        {
            Text = message;
        }

        public string Text { get; set; }
    }
}
