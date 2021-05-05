using System.ComponentModel;

namespace Curso.Domain.Enuns
{
    public enum StatusResult
    {
        [Description("NoAuth")]
        NoAuth = -2,
        [Description("TokenExpired")]
        TokenExpired = -1,
        [Description("Success")]
        Success = 0,
        [Description("Info")]
        Info = 1,
        [Description("Warning")]
        Warning = 2,
        [Description("Danger")]
        Danger = 3
    }
}
