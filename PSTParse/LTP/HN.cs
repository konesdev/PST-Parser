﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSTParse.NDB;

namespace PSTParse.LTP
{
    public class HN
    {
        public NBTENTRY HNNode;
        public List<HNBlock> HeapNodes; 

        public HN(NodeDataDTO nodeData)
        {
            this.HeapNodes = new List<HNBlock>();
            var numBlocks = nodeData.NodeData.Count;
            for (int i = 0; i < numBlocks; i++)
            {
                var curBlock = new HNBlock(i, nodeData.NodeData[i]);
                this.HeapNodes.Add(curBlock);
            }
        }
    }
}
