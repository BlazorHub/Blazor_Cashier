﻿using System;
using System.Collections.Generic;

namespace BlazorCashier.Shared
{
    public class ApiResponse
    {
        public bool IsSuccess => string.IsNullOrEmpty(Error);

        public string Error { get; }

        public ApiResponse(string error = null)
        {
            Error = error;
        }
    }

    public class EntityApiResponse<TEntity> : ApiResponse where TEntity : class
    {
        public TEntity Entity { get; set; }

        public EntityApiResponse(TEntity entity = null, string error = null)
            : base(error)
        {
            Entity = entity;
        }
    }

    public class EntitiesApiResponse<TEntity> : ApiResponse where TEntity : class
    {
        public IEnumerable<TEntity> Entities { get; set; }

        public EntitiesApiResponse(IEnumerable<TEntity> entities = null, string error = null) 
            : base(error)
        {
            Entities = entities;
        }
    }
    
    public class IdentityApiResponse : ApiResponse
    {
        public string AccessToken { get; set; }
        public DateTime ExpireDate { get; set; }

        public IdentityApiResponse()
        {

        }

        public IdentityApiResponse(string error) : base(error)
        {
            
        }

        public IdentityApiResponse(
            string accessToken,
            DateTime expireDate)
        {
            AccessToken = accessToken;
            ExpireDate = expireDate;
        }
    }
}
