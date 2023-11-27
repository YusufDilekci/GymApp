using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BranchValidator : AbstractValidator<Branch>
    {
        public BranchValidator()
        {
            RuleFor(x=> x.BranchName).NotEmpty().WithMessage("Spor dal adını boş geçemezsiniz");
            RuleFor(x => x.BranchInfo).NotEmpty().WithMessage("Spor dal bilgisini boş geçemezsiniz");
            RuleFor(x => x.BranchPrice).NotEmpty().WithMessage("Spor dal fiyatını boş geçemezsiniz");
            RuleFor(x => x.BranchName).MinimumLength(2).WithMessage("Spor dal ismi en az iki karakterden oluşmalıdır.");
        }
    }
}
