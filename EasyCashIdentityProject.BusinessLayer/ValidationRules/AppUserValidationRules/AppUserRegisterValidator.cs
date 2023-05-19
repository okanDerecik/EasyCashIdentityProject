using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez");
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Giriş Yapın");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriş Yapın");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir E-Mail Adresi Girin");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parolalarınız Eşleşmemektedir");
        }
    }
}
