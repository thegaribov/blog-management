using System;
using System.Collections.Generic;
using System.IO;

namespace blog_manageng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlogStatus blogStatus = BlogStatus.Approved;

            Console.WriteLine(blogStatus.GetNameInAzerbaijani());
            //Legv edildi
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


    static class BlogStatusExtension
    {
        public static string GetNameInAzerbaijani(this BlogStatus blogStatus, bool isAdmin = true)
        {
            if (isAdmin)
            {
                switch (blogStatus)
                {
                    case BlogStatus.Created:
                        return "Yaradildi";
                    case BlogStatus.Approved:
                        return "Tesdiqlendi";
                    case BlogStatus.Rejected:
                        return "Redd edildi";
                    default:
                        throw new Exception($"Status : {blogStatus} is not localized to azerebaijani");
                }
            }
            else
            {
                switch (blogStatus)
                {
                    case BlogStatus.Created:
                        return "Yoxlanisda";
                    case BlogStatus.Approved:
                        return "Tesdiqlendi";
                    case BlogStatus.Rejected:
                        return "Redd olundu";
                    default:
                        throw new Exception($"Status : {blogStatus} is not localized to azerebaijani");
                }
            }

            
        }
    }


}
