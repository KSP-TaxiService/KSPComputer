﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KSPComputer.Nodes;
namespace DefaultNodes
{
    [Serializable]
    public class NodeTick : EventNode
    {
        public override void OnUpdate()
        {
            if(Enabled)
                Execute(null);
        }
    }
}