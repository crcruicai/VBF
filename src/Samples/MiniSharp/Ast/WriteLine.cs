﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBF.MiniSharp.Ast
{
    public class WriteLine : Statement
    {
        public Expression Value { get; private set; }
        public WriteLine(Expression value)
        {
            Value = value;
        }
    }
}
