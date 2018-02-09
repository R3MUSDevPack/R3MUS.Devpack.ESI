using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R3MUS.Devpack.ESI.Infrastructure
{
    public class ScopeBuilder
    {
        IEnumerable<string> _scopes;

        public ScopeBuilder(IEnumerable<string> scopes)
        {
            _scopes = scopes.Distinct();
        }

        public string Build()
        {
            var stringBuilder = new StringBuilder();

            if (_scopes.Count() > 0)
            {
                stringBuilder.Append(string.Format(Resources.ScopeFormat,
                    string.Join(Resources.Plus, _scopes)
                    ));
            }

            return stringBuilder.ToString();
        }
    }
}
