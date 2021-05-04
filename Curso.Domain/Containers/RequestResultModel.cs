using Curso.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Domain.Containers
{
    public class RequestResultModel
    {
        public RequestResultModel()
        {
            Status = StatusResult.Success;
            Messages = new List<MessageModel>();
        }

        public RequestResultModel(StatusResult status, params MessageModel[] messages)
            : this()
        {
            Status = status;

            if (messages != null)
            {
                foreach (var message in messages)
                {
                    Messages.Add(message);
                }
            }
        }

        public RequestResultModel(StatusResult status, object data, params MessageModel[] messages)
            : this()
        {
            Status = status;
            Data = data;

            if (messages != null)
            {
                foreach (var message in messages)
                {
                    Messages.Add(message);
                }
            }
        }

        public StatusResult Status { get; set; }

        public Object Data { get; set; }

        public List<MessageModel> Messages { get; set; }

        public Exception Exception { get; set; }
    }

    public class RequestResultModel<T>
    {
        public RequestResultModel()
        {
            Status = StatusResult.Success;
            Messages = new List<MessageModel>();
        }

        public RequestResultModel(StatusResult status, T data)
            : this()
        {
            Status = status;
            Data = data;
        }

        public RequestResultModel(StatusResult status, params MessageModel[] messages)
            : this()
        {
            Status = status;

            if (messages != null)
            {
                foreach (var message in messages)
                {
                    Messages.Add(message);
                }
            }
        }

        public RequestResultModel(StatusResult status, T data, params MessageModel[] messages)
            : this()
        {
            Status = status;
            Data = data;

            if (messages != null)
            {
                foreach (var message in messages)
                {
                    Messages.Add(message);
                }
            }
        }

        public StatusResult Status { get; set; }

        public T Data { get; set; }

        public List<MessageModel> Messages { get; set; }

        public Exception Exception { get; set; }
    }
}
