﻿using FluentValidation;
using SUPBank.Application.Features.Menu.Commands.Requests;
using SUPBank.Application.Validations.Common;

namespace SUPBank.Application.Validations.Menu
{
    public class UpdateMenuValidator : AbstractValidator<UpdateMenuCommandRequest>
    {
        public UpdateMenuValidator()
        {
            RuleFor(r => r.Id).ValidateId();
            RuleFor(r => r.ParentId).ValidateMenuParentId();
            RuleFor(r => r.Name_TR).ValidateMenuName();
            RuleFor(r => r.Name_EN).ValidateMenuName();
            RuleFor(r => r.ScreenCode).ValidateMenuScreenCode();
            RuleFor(r => r.WebURL).ValidateMenuWebURL();
            RuleFor(r => r.Type).ValidateMenuType();
            RuleFor(r => r.Priority).ValidateMenuPriority();
            RuleFor(r => r.IsSearch).ValidateMenuIsSearch();
            RuleFor(r => r.Keyword).ValidateMenuKeyword();
            RuleFor(r => r.Authority).ValidateMenuAuthority();
            RuleFor(r => r.Icon).ValidateMenuIcon();
            RuleFor(r => r.IsGroup).ValidateMenuIsGroup();
            RuleFor(r => r.IsNew).ValidateMenuIsNew();
            RuleFor(r => r.NewStartDate).ValidateMenuNewStartDate();
            RuleFor(r => r.NewEndDate).ValidateMenuNewEndDate(r => r.NewStartDate);
            RuleFor(r => r.IsActive).ValidateIsActive();
        }
    }
}
