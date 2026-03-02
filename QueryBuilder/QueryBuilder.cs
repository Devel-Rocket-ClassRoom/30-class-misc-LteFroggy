using System;
using System.Text;

class QueryBuilder
{
   StringBuilder sb;

    public QueryBuilder() {
        sb = new StringBuilder();
    }

    public QueryBuilder Select(string columns) {
        sb.Append($"SELECT {columns}\n");
        return this;
    }
    public QueryBuilder From(string table) {
        sb.Append("FROM {table}\n");
        return this;
    }
    public QueryBuilder Where(string condition) {
        sb.Append($"WHERE {condition}\n");
        return this;
    }
    public QueryBuilder Orderby(string column) {
        sb.Append($"ORDER BY {column} ASC\n");
        return this;
    }
    public string Build() {
        return sb.Remove(sb.Length - 1, 1).Append(";").ToString();
    }
}