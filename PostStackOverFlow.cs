using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    public class PostStackOverFlow
    {
        public string title { get; set; }
        public string description { get; set; }

        public DateTime date { get; set; }

        private int vote { get; set; }
        public PostStackOverFlow( string title,string description, DateTime date)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            
        }

     

        public void upVote()
        {
            this.vote++;
            Console.WriteLine("upVote {0}",this.vote);
        }

        public void downVote()
        {
            this.vote --;
            Console.WriteLine("downVote {0}", this.vote);
        }
    }
}
