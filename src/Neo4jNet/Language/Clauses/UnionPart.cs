namespace Neo4jNet.Language
{
    /// <summary>
    /// Represents a part on an union
    /// </summary>
    public class UnionPart : Visitable
    {
        private readonly bool _all;
        private readonly SingleQuery _query;

        public UnionPart(bool all, SingleQuery query)
        {
            _all = all;
            _query = query;
        }

        public bool IsAll() => _all;

        public SingleQuery GetQuery() => _query;

        public new void Visit(CypherVisitor visitor)
        {
            visitor.Enter(this);
            _query.Visit(visitor);
            visitor.Leave(this);
        }
    }
}