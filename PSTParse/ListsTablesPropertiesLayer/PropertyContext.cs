﻿using System;
using System.Collections.Generic;
using PSTParse.MessageLayer;
using PSTParse.NodeDatabaseLayer;

namespace PSTParse.ListsTablesPropertiesLayer
{
    public class PropertyContext
    {
        public BTH BTH;

        public Dictionary<MessageProperty, ExchangeProperty> Properties;

        public PropertyContext(ulong nid, PSTFile pst)
        {
            var bytes = BlockBO.GetNodeData(nid, pst);
            var HN = new HN(bytes);
            this.BTH = new BTH(HN);
            this.Properties = this.BTH.GetExchangeProperties();
        }

        public PropertyContext(NodeDataDTO data)
        {
            var HN = new HN(data);
            this.BTH = new BTH(HN);
            this.Properties = this.BTH.GetExchangeProperties();
        }
    }
}