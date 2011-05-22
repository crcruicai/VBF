﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBF.Compilers.Scanners;
using System.Collections.ObjectModel;

namespace VBF.MiniSharp.Ast
{
    public class MethodDecl
    {
        public Type ReturnType { get; private set; }
        public Lexeme Name { get; private set; }
        public ReadOnlyCollection<Formal> Parameters { get; private set; }
        public ReadOnlyCollection<Statement> Statements { get; private set; }
        public Expression ReturnExpression { get; private set; }

        public MethodDecl(Lexeme name, Type retType, IList<Formal> parameters, IList<Statement> stmts, Expression retExp)
        {
            Name = name;
            ReturnType = retType;
            Parameters = new ReadOnlyCollection<Formal>(parameters);
            Statements = new ReadOnlyCollection<Statement>(stmts);
            ReturnExpression = retExp;
        }
    }
}
