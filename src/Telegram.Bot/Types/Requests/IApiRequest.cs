﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Telegram.Bot.Types.Requests
{
    /// <summary>
    /// Represents a request to be sent to telegrams bot API
    /// </summary>
    public interface IApiRequest
    {
        /// <summary>
        /// The encoding that should be used for this request
        /// </summary>
        RequestEncoding Encoding { get; }
        /// <summary>
        /// The method of this request
        /// </summary>
        string Method { get; set; }
        /// <summary>
        /// The parameters of this object
        /// </summary>
        Dictionary<string, object> Parameters { get; set; }
        /// <summary>
        /// The file to be sent. Only present if a file is sent as a stream.
        /// </summary>
        Stream FileStream { get; set; }
        /// <summary>
        /// The name of the file. Only present if <see cref="FileStream"/> is present.
        /// </summary>
        string FileName { get; set; }
    }
}
