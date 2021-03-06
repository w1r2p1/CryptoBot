﻿using CryptoBot.Utils.General;

namespace CryptoBot.TickerServices
{
    /// <summary>
    /// Interface definition for TickerService subscriber
    /// </summary>
    public interface ITickerSubscriber
    {
        /// <summary>
        /// Receiver method for new TickData
        /// </summary>
        /// <param name="tickData">The TickData</param>
        /// <param name="exchange">Exchange that deliver this tick</param>
        void OnTick(Exchange exchange, TickData tickData);
    }
}
