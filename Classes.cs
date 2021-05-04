using System;
using System.Collections.Generic;

namespace Deferment
{
    
    public class ProductionNetworkNode
    {
        public Guid Id;
        public string Name;
        public string Description;
        public string Type;
        public string State;

        public List<ConnectionInfo> Connections;
        public List<ProductionLimits> ProductionLimits;
        public List<ExtendedInfo> ExtendedeInfo;

    }

    public class ExtendedInfo
    {
        public string Name;
        public string Value;
    }

    public class ConnectionInfo
    {
        public Guid ParentId;
        public List<FlowInfo> Flow;
    }

    public class FlowInfo
    {
        public readonly string Product;
        public readonly float MaxFlow;
        public readonly float MinFlow;
        public string UOM;
    }


    public class ProductionLimits
    {
        public string Product;
        public float MinProduction;
        public float MaxProduction;
        public string UOM;
    }
}
