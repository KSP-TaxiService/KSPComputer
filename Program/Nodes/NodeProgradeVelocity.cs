﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSPFlightPlanner.Program.Connectors;
namespace KSPFlightPlanner.Program.Nodes
{
    [Serializable]
    public class NodeProgradeVelocity : Node
    {
        public new static string Name = "Prograde Velocity";
        public new static string Description = "Returns the velocity along the forward axis";
        public new static SVector3 Color = new SVector3(0.5f, 1f, 0.5f);
        public new static SVector2 Size = new SVector2(190, 50);
        protected override void OnCreate()
        {
            Out<float>("Velocity");
        }
        protected override void OnUpdateOutputData()
        {
            Out("Velocity", Vector3.Dot(Program.Vessel.ReferenceTransform.up, Program.Vessel.obt_velocity));
        }
    }
}