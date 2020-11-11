﻿using System;
namespace Neo4jNet.Language.Clauses
{
    /// <summary>
    /// 
    /// </summary>
    public class DistinctExpression : Expression
    {
        private readonly Expression _expression;

        public DistinctExpression(Expression expression)
        {
            _expression = expression;
        }

        public new void Visit(CypherVisitor visitor)
        {
            visitor.Enter(this);

            _expression.Visit(visitor);
            visitor.Leave(this);
        }
    }
}
