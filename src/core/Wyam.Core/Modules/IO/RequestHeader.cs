﻿using System;
using System.Collections.Generic;

namespace Wyam.Core.Modules.IO
{
    /// <summary>
    /// Fields in the request header of a web request.
    /// </summary>
    public class RequestHeader
    {
#pragma warning disable 1591
        public List<string> Accept { get; set; } = new List<string>();

        public List<string> AcceptCharset { get; set; } = new List<string>();

        public List<string> AcceptEncoding { get; set; } = new List<string>();

        public List<string> AcceptLanguage { get; set; } = new List<string>();

        public Tuple<string, string> BasicAuthorization { get; private set; }

        public List<string> Connection { get; set; } = new List<string>();

        public DateTimeOffset? Date { get; set; }

        public List<string> Expect { get; set; } = new List<string>();

        public bool? ExpectContinue { get; set; }

        public string From { get; set; }

        public string Host { get; set; }

        public List<string> IfMatch { get; set; } = new List<string>();

        public DateTimeOffset? IfModifiedSince { get; set; }

        public List<string> IfNoneMatch { get; set; } = new List<string>();

        public DateTimeOffset? IfUnmodifiedSince { get; set; }

        public int? MaxForwards { get; set; }

        public Uri Referrer { get; set; }

        public List<string> TransferEncoding { get; set; } = new List<string>();

        public bool? TransferEncodingChunked { get; set; }

        public void SetBasicAuthorization(string username, string password)
        {
            BasicAuthorization = Tuple.Create(username, password);
        }
#pragma warning restore 1591
    }
}
