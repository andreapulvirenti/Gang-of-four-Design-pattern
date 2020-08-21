
using System;
using System.Collections.Generic;

namespace Memento
{
    public class SessionState
    {
        public int SessionId { get; set; }

        public string CurrenteUrlWebpage { get; set; }

        public int PagesVisited { get; set; }

        public List<string> UrlHistory { get; set; }

    }
}