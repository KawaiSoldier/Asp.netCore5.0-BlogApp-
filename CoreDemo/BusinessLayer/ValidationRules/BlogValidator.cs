using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {

        public BlogValidator()
        {

            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik Boş Geçilemez");

            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Kategori Boş Geçilemez");
        }


    }
}
