using Application.Interface;
using Application.Request.Notification;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class NotificationService
    {
        private readonly IClaimService _service;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService service)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

       /* public async Task<ApiResponse> CreateNotificationAsync(NotificationRequest request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var claim = _service.GetUserClaim();
                if (claim == null)
                {
                    return response.SetNotFound("Cannot found Claim" + claim);
                }
                var account = await _unitOfWork.UserAccounts.GetAsync(a => a.Id == claim.Id);
                if (claim.Role == Domain.Entities.Role.JobSeeker)
                {
                    var email = account.Email;
                    var name = account.FirstName + account.LastName;

                    request.Title = "A new candidate wants to apply to your company";
                    request.Description = $"Candidate: {name}\nEmail: {email}\nThey have expressed interest in applying for a position at your company.";
                }
                if (claim.Role == Domain.Entities.Role.Employer)
                {
                    request.Title = "";
                    request.Description = "";
                }

                var getLatestJobPostActivity = await _unitOfWork.JobPostActivities.GetLatestJobPostActivityAsync(claim.Id);
                var updateJobPostActity = 
                var noti = _mapper.Map<Notification>(request);
                noti.ReceiverId = null;

                return response.SetOk("Notification created successfully");
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }*/
    }
}
