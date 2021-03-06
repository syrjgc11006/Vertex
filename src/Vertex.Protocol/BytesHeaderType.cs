﻿namespace Vertex.Protocol
{
    /// <summary>
    /// 消息序列化传输的类别
    /// </summary>
    public enum BytesHeaderType : byte
    {
        /// <summary>
        /// 通用序列化消息
        /// </summary>
        Msg = 0,

        /// <summary>
        /// 事件序列化消息
        /// </summary>
        Event = 1
    }
}
