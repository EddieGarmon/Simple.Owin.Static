﻿namespace Simple.Owin.Static
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class StaticFile
    {
        private readonly string _path;
        private readonly string _alias;
        private readonly IList<Tuple<string, string>> _headers;

        public StaticFile(string path, string @alias, IList<Tuple<string, string>> headers)
        {
            _path = MapPath.Map(path);
            _alias = alias;
            _headers = headers;
        }

        public IEnumerable<Tuple<string, string>> Headers
        {
            get { return _headers ?? Enumerable.Empty<Tuple<string, string>>(); }
        }

        public string Alias
        {
            get { return _alias; }
        }

        public string Path
        {
            get { return _path; }
        }
    }
}