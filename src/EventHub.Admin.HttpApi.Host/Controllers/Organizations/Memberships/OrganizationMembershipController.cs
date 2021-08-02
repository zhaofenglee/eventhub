using System.Threading.Tasks;
using EventHub.Admin.Organizations.Memberships;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace EventHub.Admin.Controllers.Organizations.Memberships
{
    [Controller]
    [Area("eventhub-admin")]
    [ControllerName("OrganizationMembership")]
    [Route("/api/eventhub/organization-memberships")]
    public class OrganizationMembershipController : AbpController, IOrganizationMembershipAppService
    {
        private readonly IOrganizationMembershipAppService _organizationMembershipAppService;

        public OrganizationMembershipController(IOrganizationMembershipAppService organizationMembershipAppService)
        {
            _organizationMembershipAppService = organizationMembershipAppService;
        }

        [HttpGet]
        public async Task<PagedResultDto<OrganizationMemberDto>> GetListAsync(OrganizationMemberListFilterDto input)
        {
            return await _organizationMembershipAppService.GetListAsync(input);
        }
    }
}