﻿using SGA.Application.Domain.Responsible;
using SGA.Application.Repository.Core;
using SGA.Application.Repository.Responsible;
using SGA.Domain.Core;
using SGA.Domain.Responsible.Validations;
using System.Linq;
using Models = SGA.Domain.Entities.Models;

namespace SGA.Domain.Responsible.Commands
{
    public class RegisterNewResponsibleCommand : Command<Models.Responsible>, IRegisterNewResponsibleCommand
    {
        private readonly IResponsibleRepository _responsibleRepository;

        public RegisterNewResponsibleCommand(IResponsibleRepository responsibleRepository, IUnitOfWork uow)
            : base(uow)
        {
            _responsibleRepository = responsibleRepository;
        }

        public override void Execute(Models.Responsible obj)
        {
            var validation = new RegisterNewResponsibleValidation().Validate(obj);

            if (!validation.IsValid)
            {
                AddErros(validation.Errors.Select(x => x.ErrorMessage).ToList());
                return;
            }

            obj.CreateNewId();

            _responsibleRepository.Add(obj);

            Commit();
        }
    }
}