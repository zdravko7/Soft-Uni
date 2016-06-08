using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class Problem
    {
        public int Id { get; set; }
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value == null || value == "" || value.Length < 3)
                {
                    throw new ArgumentException("The title must be at least 3 symbols long");
                }
                this.title = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value == null || value == "" || value.Length < 5)
                {
                    throw new ArgumentException("The description must be at least 5 symbols long");
                }
                description = value;
            }
        }
        public Problem(string title, string description, IssuePriorität priority, List<string> tags)
        {
            Title = title;
            Description = description;
            Priority = priority;
            Tags = tags;
        }
        public IssuePriorität Priority { get; set; }
        public IList<string> Tags { get; set; }
        public IList<Kommentar> Comments { get; set; }
        public void AddComment(Kommentar comment)
        {
            this.Comments.Add(comment);
        }
        public override string ToString()
        {
            var issue = new StringBuilder();
            issue.AppendLine(this.Title).AppendFormat("Priority: {0}", this.GetPriorityAsString()).AppendLine().AppendLine(this.Description);
            if (this.Tags.Count > 0)
                issue.AppendFormat("Tags: {0}", string.Join(",", this.Tags.OrderBy(t => t))).AppendLine();

            if (this.Comments.Count > 0)
            {
                issue.AppendFormat("Comments:{0}{1}", Environment.NewLine, string.Join(Environment.NewLine, this.Comments)).AppendLine();
            }
            return issue.ToString().Trim();
        }

        private string GetPriorityAsString()
        {
            switch (this.Priority)
            {
                case IssuePriorität.Showstopper: return "****";
                case IssuePriorität.High: return "***";
                case IssuePriorität.Medium: return "**";

                case IssuePriorität.Low: return "*";
                default: throw new InvalidOperationException("The priority is invalid");
            }
        }

        private string title;
        private string description;
    }
}
