﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DialogueEditor
{
    public class NodeAction : ICloneable
    {
        //--------------------------------------------------------------------------------------------------------------
        // Serialized vars
        
        public bool OnNodeStart { get; set; }

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public NodeAction()
        {
            OnNodeStart = true;
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        public virtual string GetTreeText()
        {
            return GetDisplayText();
        }

        public virtual string GetDisplayText()
        {
            return "[NodeAction]";
        }
    }
}
