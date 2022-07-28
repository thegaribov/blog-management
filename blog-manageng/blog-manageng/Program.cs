using System;
using System.Collections.Generic;
using System.IO;

namespace blog_manageng
{
    internal class Program
    {
        static void Main(string[] args)
        {
                

        }

    }

    class Blog
    {
        public Blog(string title, string content, BlogStatus status, params string[] tags)
        {
            Title = title;
            Content = content;
            Status = status;
            Tags = tags;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public BlogStatus Status { get; set; }
        public string[] Tags { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }

    enum BlogStatus
    {
        Created,
        Approved,
        Rejected
    }



}
