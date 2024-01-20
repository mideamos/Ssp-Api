﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.NewModel;
using SelfPortalAPi;
using Swashbuckle.AspNetCore.Annotations;
using SelfPortalAPi.UnitOfWork;
using SelfPortalAPi.FormModel;
using AutoMapper;
using SelfPortalAPi.NewModel;
using SelfPortalAPi.Model;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly PinscherSpikeContext _repo;
        private string errMsg = "Unable to process request, kindly try again";
        public BusinessController(IMapper mapper, PinscherSpikeContext repo)
        {
            _repo = repo;
            _mapper = mapper;
        }



        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("getallbybusinessId/{businessId}/bycompanyId/{companyId}")]
        public Task<IActionResult> GetAllByBusinessIdByCompanyId([FromRoute] string businessId, [FromRoute] string companyId)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                var retVal = _repo.AssetTaxPayerDetailsApis.ToList();
                var ret = _repo.AssetTaxPayerDetailsApis.Where(o => o.AssetId == Convert.ToInt32(businessId) && o.TaxPayerId == Convert.ToInt32(companyId)).ToList();
                r.data = GetList(ret);
                return Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("getallBussinessbycompanyId/{companyId}")]
        public Task<IActionResult> GetAllBussiness([FromRoute] string companyId)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                var getRin = _repo.UserManagements.FirstOrDefault(o=>o.Id == Convert.ToInt32(companyId));
                var ret = _repo.AssetTaxPayerDetailsApis.Where(o => o.TaxPayerRinnumber == getRin.CompanyRin).ToList();
                r.data = GetList(ret);
                return Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("getallBussinessbycompanyRin/{companyRin}")]
        public Task<IActionResult> GetAllBussinessByRin([FromRoute] string companyRin)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                var ret = _repo.AssetTaxPayerDetailsApis.Where(o => o.TaxPayerRinnumber == companyRin).ToList();
                r.data = GetList(ret);
                return Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }


        private IList<BusinessVm> GetList(List<AssetTaxPayerDetailsApi> det)
        {
            var list = new List<BusinessVm>();
            for (int i = 0; i < det.Count(); i++)
            {
                list.Add(new BusinessVm
                {
                    business_id = det[i].AssetId.ToString(),
                    business_name = det[i].AssetName,
                    lga_name = det[i].AssetLga
                });
            }
            return list;
        }

        //[HttpGet]
        //[SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        //[Route("GetbyId/{id}")]

        //public Task<IActionResult> GetbyId([FromRoute] int id)
        //{
        //    var r = new ReturnObject();
        //    r.status = true;
        //    r.message = "Record Fetched Successfully";
        //    try
        //    {

        //        r.data = _repo.Get(id);
        //        return Task.FromResult<IActionResult>(Ok(r));

        //    }
        //    catch (System.Exception ex)
        //    {
        //        return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
        //        {
        //            status = false,
        //            message = ex.Message
        //        }));
        //    }

        //}

        //[HttpPost]
        //[SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        //[Route("AddBusiness")]
        //public Task<IActionResult> AddEmployee([FromBody] BusinessViewModel obj)
        //{
        //    var emp = _mapper.Map<Business>(obj);
        //    emp.UniqueId = Guid.NewGuid().ToString();
        //    try
        //    {
        //        _repo.Insert(emp);
        //     //   var empData = _mapper.Map<BusinessFormModel>(emp);
        //     //   var com = _repo.Get(Convert.ToInt32(obj.BusinessOperationID));

        //        var r = new ReturnObject();
        //        r.status = true;
        //        r.data = emp;
        //        r.message = "Record saved Successfully";
        //        return Task.FromResult<IActionResult>(Ok(r));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
        //        {
        //            status = false,
        //            message = ex.Message
        //        }));
        //    }
        //}
    }
}
