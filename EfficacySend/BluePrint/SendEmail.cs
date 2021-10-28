﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficacySend.BluePrint
{
   public class SendEmail
    {
        public string ApiKey { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string ToEmail { get; set; }
        public string ToName { get; set; }
        public string Subject { get; set; }
        public string PlainEmail { get; set; }
        public string HtmlEmail { get; set; }
    }
    public class SendEmailResponse
    {
        public bool IsHtmlValid { get; set; }
        public bool IsEmailSent { get; set; }
        public string Message { get; set; }
    }
}
