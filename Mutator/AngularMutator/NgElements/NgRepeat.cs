using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator.NgElements
{
    internal class NgRepeat : AttributeValue
    {
        public string Collection { get; private set; }
        public string Iterator { get; private set; }
        public string TrackBy { get; private set; }
        public List<string> Filters { get; private set; }

        public NgRepeat(string collection, string iterator, string trackBy = null, IEnumerable<string> filters = null)
        {
            Collection = collection;
            Iterator = iterator;
            TrackBy = trackBy;
            Filters = filters?.ToList() ?? null;
        }

        public override string ToAttribute()
        {
            var sb = new StringBuilder();
            sb.Append($"{Iterator} in {Collection}");

            if (TrackBy != null)
                sb.Append($" track by {TrackBy}");

            if (Filters != null)
                sb.Append(" | " + string.Join(" | ", Filters));

            return sb.ToString();

        }
    }
}
