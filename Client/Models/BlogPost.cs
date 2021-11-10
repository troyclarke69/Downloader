using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Client
{
    public class BlogPost
    {
        //public string Title { get; set; }
        //public string Slug { get; set; }
        //public string Content { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Message { get; set; }

    }

    public class BlogPostValidator : AbstractValidator<BlogPost>
    {
        public BlogPostValidator()
        {
            //RuleFor(x => x.Title).NotEmpty();
            //RuleFor(x => x.Slug).NotEmpty().Length(3, 16);
            //RuleFor(x => x.Content).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Message).NotEmpty();

        }
    }
}