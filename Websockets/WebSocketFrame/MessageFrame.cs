﻿using nanoframework.System.Net.Websockets.WebSocketFrame;
using System.Net;

namespace nanoframework.System.Net.Websockets
{
    /// <summary>
    /// The base WebSocket Message frame.
    /// </summary>
    public class MessageFrame
    {

        internal OpCode OpCode { get; set; }
        internal bool IsControllFrame { get => (int)OpCode > 7; }
        internal bool Error { get => ErrorMessage != null; }
        internal string ErrorMessage { get; set; } = null;

        /// <summary>
        /// The Remote Endpoint from which the message is received.
        /// </summary>
        public IPEndPoint EndPoint { get; set; }

        /// <summary>
        /// Indicates whether the current message is a UTF-8 message or a binary message.
        /// </summary>
        public WebSocketMessageType MessageType => OpCode == OpCode.TextFrame ? WebSocketMessageType.Text : WebSocketMessageType.Binary;
    }
}
