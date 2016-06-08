using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buhtig.Stuff;
using Wintellect.PowerCollections;

namespace buhtig.Interfaces
{
    interface IBuhtigIssueTrackerData
    {
        Benutzer TheUserWhichHasCurrentlyLoggedIntoTheIssueTrackingSystem { get; set; }
        IDictionary<string, Benutzer> users_dict { get; }
        OrderedDictionary<int, Issue> issues1 { get; }
        MultiDictionary<string, Issue> issues2 { get; }
        MultiDictionary<string, Issue> issues4 { get; }
        MultiDictionary<Benutzer, Kommentar> dict { get; }
        int AddIssue(Issue p);
        void RemoveIssue(Issue p);
    }
}
