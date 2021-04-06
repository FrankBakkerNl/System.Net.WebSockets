﻿namespace nanoframework.System.Net.Websockets.WebSocketFrame
{
    /// <summary>
    /// Indicates the message type.
    /// </summary>
    public enum WebSocketMessageType
    {
        /// <summary>
        /// The message is clear text.
        /// </summary>
        Text = 0,

        /// <summary>
        /// The message is in binary format.
        /// </summary>
        Binary = 1,
    }
}
