using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogWebAPI.Filters;
using BlogWebAPI.Filters.CustomExceptions;
using BlogWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogWebAPI.Controllers
{
    //[CustomAuthorizeFilter]
    public class UsersController : ApiController
    {

        private IUserService _service;
        private IMapper _mapper;
        public UsersController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<UserData> Get()
        {
            var usersBL = _service.GetAll();
            var usersPL = _mapper.Map<IEnumerable<UserData>>(usersBL);
            return usersPL;
        }

        // GET: api/Users/5
        [HttpGet]
        [CustomExeptionFilter]
        public UserData Get(int id)
        {
            var userBL = _service.GetById(id);
            var userPL = _mapper.Map<UserData>(userBL);
            if (userPL == null)
            {
                throw new InvalidIdExeption("user with this id is not found", id.ToString());
            }
            return userPL;
        }

        // POST: api/Users
        [HttpPost]
        [CustomExeptionFilter]
        public void Post([FromBody]UserData user)
        {
            if(string.IsNullOrEmpty(user.FirstName))
            {
                throw new InvalidNameException("invalid user first name", "name is null or empty");
            }
            else if (string.IsNullOrEmpty(user.LastName))
            {
                throw new InvalidLastNameException("invalid user last name", "name is null or empty");
            }

            var userPL = _mapper.Map<UserBL>(user);
            _service.Create(userPL);
        }

        // PUT: api/Users/5
        [HttpPut]
        public void Put([FromBody]UserData user)
        {
            if (string.IsNullOrEmpty(user.FirstName))
            {
                throw new InvalidNameException("invalid user first name", "name is null or empty");
            }
            else if (string.IsNullOrEmpty(user.LastName))
            {
                throw new InvalidNameException("invalid user last name", "name is null or empty");
            }

            var userPL = _mapper.Map<UserBL>(user);
            _service.Update(userPL);
        }

        // DELETE: api/Users/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
