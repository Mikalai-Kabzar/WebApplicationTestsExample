using Framework.Lib.Entities.Objects;

namespace Framework.Lib.Entities.Builders
{
    public class QueryBuilder : IBuilder<Query>
    {
        public Query Object { get; set; }

        public QueryBuilder()
        {
            Object = new Query();
        }

        public QueryBuilder WithText()
        {
            Object.Text = "iPhone";
            return this;
        }

        public Query Create()
        {
            return Object;
        }
    }
}
