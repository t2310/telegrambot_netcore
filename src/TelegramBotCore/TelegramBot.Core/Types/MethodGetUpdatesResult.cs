using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class MethodGetUpdatesResult : MethodResultBase
    {
        public List<Update> Result { get; set; } = new List<Update>();
    }
}
