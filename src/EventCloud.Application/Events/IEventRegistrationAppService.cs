﻿using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EventCloud.Events.Dtos;

namespace EventCloud.Events
{
    public interface IEventRegistrationAppService : IApplicationService
    {
        Task<EventRegisterOutput> Register(EntityRequestInput<Guid> input);

        Task CancelRegistration(EntityRequestInput<Guid> input);
    }
}